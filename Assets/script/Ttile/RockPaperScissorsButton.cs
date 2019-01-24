using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockPaperScissorsButton : MonoBehaviour {

    public void ButtonPush()
    {
        GameMode.SetGameType(GameMode.GameType.RockPaperScissors);
        SceneChang.Change(SceneChang.SceneState.RockPaperScissors);
    }
}
