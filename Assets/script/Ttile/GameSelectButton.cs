using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSelectButton : MonoBehaviour {

    public void RockPaperScissors()
    {
        GameMode.SetGameType(GameMode.GameType.RockPaperScissors);
        SceneChang.Change(SceneChang.SceneState.RockPaperScissors);
    }
    public void Calculation()
    {
        GameMode.SetGameType(GameMode.GameType.Calculation);
        SceneChang.Change(SceneChang.SceneState.Calculation);
    }
    public void BirdView()
    {
        GameMode.SetGameType(GameMode.GameType.BirdView);
        SceneChang.Change(SceneChang.SceneState.BirdView);
    }
}
