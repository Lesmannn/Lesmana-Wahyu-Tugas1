using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseHewan : MonoBehaviour, IClickable
{
    protected int speed = 1;

    public abstract void Move();
    public virtual void Destroy()
    {
        Destroy(this.gameObject);
    }
    protected void Update()
    {
        Move();
    }

    public virtual void OnClick()
    {
        Destroy();
        ScoreManager.instance.AddScore();
    }
}
