using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KecoaRaksasa : BaseHewan
{

    bool change;
    public override void Move()
    {
        if (change)
        {
            transform.Translate(new Vector2(2f, -0.3f) * speed * 5 * Time.deltaTime);
        }
        else
        {
            transform.Translate(new Vector2(-2f, -0.3f) * speed * 5 * Time.deltaTime);
        }
        if (this.gameObject.transform.position.x <= -3)
        {
            change = true;
        }
        else if (this.gameObject.transform.position.x >= 3)
        {
            change = false;
        }
        
    }
    public override void Destroy()
    {
        base.Destroy();
    }

}
