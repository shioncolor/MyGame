using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Glovalobjcts;
using SceneGlobalVariables;

public class RetryButton : MonoBehaviour {

    public void ButtonPush()
    {
        Score.Reset();
        Glovalobj.Instance.sceneChang.Change(SceneChang.SceneState.Zyankenn);
    }
}
