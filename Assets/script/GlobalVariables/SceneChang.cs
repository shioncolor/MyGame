using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class SceneChang : MonoBehaviour
{

    public enum SceneState
    {
        Title = 0,
        Zyankenn,
        Result,
    }

    void start()
    {

    }

    public void Change(SceneState sceneState)
    {
        switch (sceneState)
        {
            case SceneState.Title:
                SceneManager.LoadScene("Title");
                break;

            
            case SceneState.Zyankenn:
                SceneManager.LoadScene("zyannken");
                break;

            case SceneState.Result:
                SceneManager.LoadScene("Result");
                break;
        }
    }
}
