using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Glovalobjcts;

public class ZyannkenButton : MonoBehaviour {

    public void ButtonPush()
    {
        Glovalobj.Instance.sceneChang.Change(SceneChang.SceneState.Zyankenn);
    }
}
