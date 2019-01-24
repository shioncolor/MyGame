using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSelectButton : MonoBehaviour {

    public void RockPaperScissors()
    {
        GameMode.SetGameType(GameMode.GameType.RockPaperScissors);
        SceneChang.Change(SceneChang.SceneState.RockPaperScissors);
    }
}
