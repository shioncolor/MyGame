using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneGlobalVariables;

public class Return : MonoBehaviour {

    string StartButton = "Return";

    // Update is called once per frame
    void Update () {
        //押されたらタイトルに移行
        if (GlobalVariables.Instance.touch.JugeObjctName(StartButton))
        {
            GlobalVariables.Instance.activeManager.ChangActive(ActiveManager.GameStatus.Title);
        }
    }
}
