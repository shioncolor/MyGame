using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefabKey : MonoBehaviour
{
    private static string[] SeveScoreKeY =
    {
           "RockPaperScissors",
            "Test",
            "Test2",
            "Test3"
         };

    public static string GetKey(int num)
    {
        return SeveScoreKeY[num];
    }
}

