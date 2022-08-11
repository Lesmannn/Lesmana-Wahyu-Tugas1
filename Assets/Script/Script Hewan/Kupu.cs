using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kupu : BaseHewan
{

    public override void Move()
    {
        transform.Translate(Vector2.down * speed * 2 * Time.deltaTime);
    }
    public override void Destroy()
    {
        base.Destroy();
    }
    public override void OnClick()
    {
        Destroy();
        GameManager.instance.gameOver();
    }
}
