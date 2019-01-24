using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefabKey : MonoBehaviour
{
    private static string[] SeveScoreKeY =
    {
           "RockPaperScissors",
            "Test"
         };

    public static string GetKey(int num)
    {
        return SeveScoreKeY[num];
    }
}

