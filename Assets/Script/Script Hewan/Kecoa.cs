using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kecoa : BaseHewan
{

    public override void Move()
    {
        transform.Translate(Vector2.down * speed * 3 * Time.deltaTime);
    }
    public override void Destroy()
    {
        base.Destroy();
    }
}
