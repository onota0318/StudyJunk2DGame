using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnkoAction : MonoBehaviour
{
    protected void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "BottomWall")
        {
            if (this.gameObject.name == "unko(Clone)")
            {
                Destroy(this.gameObject);
            }
        }
    }
}
