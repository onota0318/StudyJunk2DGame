using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartAction : MonoBehaviour
{
    public string sceneName;

    protected void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}
