using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneGlobalVariables;

public class ReturnButton : MonoBehaviour {

    public void ButtonPush()
    {
        Score.Reset();
        GlobalVariables.Instance.sceneChang.Change(SceneChang.SceneState.Title);
    }
}
