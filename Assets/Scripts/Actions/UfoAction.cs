using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UfoAction : MonoBehaviour
{
    public GameObject canvas; //キャンバス
    public GameObject newPrefab; // Inspector
    public GameObject score; // Inspector
    private readonly float speed = 8;
    private readonly float span = 0.8f;
    private float transX = 0;
    private float delta = 0;

    // Start is called before the first frame update
    protected void Start()
    {
        transX = speed / 50;
    }

    protected void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject unkoPrefab = Instantiate(newPrefab) as GameObject;
            unkoPrefab.transform.SetParent(canvas.transform, false);
            
            Vector2 currentUfo = transform.position;
            unkoPrefab.transform.position = new Vector2(currentUfo.x, 2);

            score.GetComponent<Text>().text = Score.counter.ToString();
        }
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
