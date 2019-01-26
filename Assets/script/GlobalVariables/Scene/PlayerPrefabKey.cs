using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefabKey : MonoBehaviour
{
    private static string[] SeveScoreKey =
    {
           "RockPaperScissors",
            "Calculation",
            "BirdView",
            "Test3"
     };

    public static string GetKey(int num)
    {
        return SeveScoreKey[num];
    }
}

