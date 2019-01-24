using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneGlobalVariables;
using Glovalobjcts;

public class BackButton : MonoBehaviour {

    public void ButtonPush()
    {
        Score.Reset();
        Glovalobj.Instance.sceneChang.Change(SceneChang.SceneState.Title);
    }
}
