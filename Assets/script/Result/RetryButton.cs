using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryButton : MonoBehaviour {

    public void ButtonPush()
    {
        Score.Reset();
        SceneChang.Change(SceneChang.SceneState.RockPaperScissors);
    }
}
