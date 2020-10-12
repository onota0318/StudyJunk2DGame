using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *
 */
public class HumanChangeAnimation : MonoBehaviour
{
    public string rightAnime = ""; // Inspectorで設定
    public string leftAnime = ""; //  Inspectorで設定

    private readonly float speed = 5;
    private float transX = 0;
    private string currentAnime = "";

    protected void Start()
    {
        currentAnime = rightAnime;
        transX = speed / 50;
    }

    protected void Update()
    {
        if (Input.GetKey("left")) {
            currentAnime = leftAnime;
            transX = (speed * -1) / 50;
        }

        if (Input.GetKey("right")) {
            currentAnime = rightAnime;
            transX = speed / 50;
        }
    }

    protected void FixedUpdate()
    {
        GetComponent<Animator>().Play(currentAnime);
        transform.Translate(transX, 0, 0);
    }

    protected void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "RightWall")
        {
            currentAnime = leftAnime;
            transX = (speed * -1) / 50;
        }

        if (col.gameObject.name == "LeftWall")
        {
            currentAnime = rightAnime;
            transX = speed / 50;
        }
    }
}
