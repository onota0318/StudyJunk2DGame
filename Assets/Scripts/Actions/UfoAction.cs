using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoAction : MonoBehaviour
{
    private readonly float speed = 8;
    private float transX = 0;

    // Start is called before the first frame update
    protected void Start()
    {
        transX = speed / 50;
    }

    protected void FixedUpdate()
    {
        transform.Translate(transX, 0, 0);
    }

    protected void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "RightWall")
        {
            transX = (speed * -1) / 50;
        }

        if (col.gameObject.name == "LeftWall")
        {
            transX = speed / 50;
        }
    }
}
