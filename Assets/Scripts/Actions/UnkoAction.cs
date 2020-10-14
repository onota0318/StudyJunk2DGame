using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnkoAction : MonoBehaviour
{
    public GameObject score; // Inspector

    protected void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "BottomWall")
        {
            Score.counter += 1;

            if (gameObject.name == "unko(Clone)")
            {
                Destroy(gameObject);
            }
        }
    }
}
