using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    private EnemyMove enemy;

    
    //public int giveScore = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D click = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (click.collider != null)
            {
                IClickable tap = click.collider.GetComponent<IClickable>();
                if (tap != null)
                {
                    tap.OnClick();
                }

            }
        }
        
    }

}
