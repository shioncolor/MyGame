using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class RetryButton : MonoBehaviour {

    private int num;
    public void ButtonPush()
    {
        Score.Reset();
        num = (int)GameMode.GetGameType();
        SceneChang.Change((SceneChang.SceneState)Enum.ToObject(typeof(SceneChang.SceneState), num+2));
    }
}
