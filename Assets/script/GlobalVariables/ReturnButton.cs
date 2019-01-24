using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneGlobalVariables;

public class ReturnButton : MonoBehaviour {

    public void ButtonPush()
    {
        Score.Reset();
        SceneChang.Change(SceneChang.SceneState.Title);
    }
}
