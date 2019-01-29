using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour {

    public void ButtonPush()
    {
        SceneChang.Change(SceneChang.SceneState.Title);
    }
}
