using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode : MonoBehaviour
{

    public enum GameType
    {
        RockPaperScissors = 0,
        Calculation
    }

    private static GameType gameType;

    public static void SetGameType(GameType PlayGame)
    {
        gameType = PlayGame;
    }

    public static GameType GetGameType()
    {
        return gameType;
    }
}
