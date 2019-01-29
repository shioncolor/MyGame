using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode : MonoBehaviour
{

    public enum GameType
    {
        RockPaperScissors = 0,
        Calculation,
        BirdView
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

    private static string[] GameName =
    {
        "後出しじゃんけん",
        "四則演算",
        "バードビュー",
        "Test"
    };

    public static string GetGameName(int num)
    {
        return GameName[num];
    }

    public static string GetGameName()
    {
        return GameName[(int)gameType];
    }
}
