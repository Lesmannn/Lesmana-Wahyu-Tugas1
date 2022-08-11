using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerKecoaRaksasa : MonoBehaviour
{
    public GameObject objectToSpawn;
    public int jumlahEnemy;
    public float xPos;
    public float yPos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Spawn()
    {
        while (jumlahEnemy < 30)
        {
            xPos = Random.Range(-8, 8);
            yield return new WaitForSeconds(12f);
            Instantiate(objectToSpawn, new Vector3(xPos, 6, 0), Quaternion.identity);
            jumlahEnemy += 1;
        }
    }

}
