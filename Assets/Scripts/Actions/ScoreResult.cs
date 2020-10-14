using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreResult : MonoBehaviour
{
    public GameObject score; // Inspector

    // Start is called before the first frame update
    protected void Start()
    {
        score.GetComponent<Text>().text = Score.counter.ToString();
    }
}
