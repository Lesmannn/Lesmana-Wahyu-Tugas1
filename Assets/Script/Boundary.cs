using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    public GameObject objectDestroy;
    public int score = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag ("Human"))
        {
            Destroy(col.gameObject);
            ScoreManager.instance.AddScore();
        }
        else if (col.gameObject.CompareTag("Enemy"))
        {
            Destroy(col.gameObject);
            GameManager.instance.takeDamage();
        }
    }
}
