using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPaperScissorsButton : MonoBehaviour {

    public void ButtonPush()
    {
        SceneChang.Change(SceneChang.SceneState.RockPaperScissors);
    }
}
