using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public void RockPaperScissorsButtonPush()
    {
        Manager.Key = 0;
        Manager.ScoreArray = PlayerPrefsX.GetFloatArray(PlayerPrefabKey.GetKey(0), 0, Manager.ScoreArray.Length);
    }

    public void TestButtonPush()
    {
        Manager.Key = 1;
        Manager.ScoreArray = PlayerPrefsX.GetFloatArray(PlayerPrefabKey.GetKey(1), 0, Manager.ScoreArray.Length);
    }

    public void TestButtonPush2()
    {
        Manager.Key = 2;
        Manager.ScoreArray = PlayerPrefsX.GetFloatArray(PlayerPrefabKey.GetKey(2), 0, Manager.ScoreArray.Length);
    }

    public void TestButtonPush3()
    {
        Manager.Key = 3;
        Manager.ScoreArray = PlayerPrefsX.GetFloatArray(PlayerPrefabKey.GetKey(3), 0, Manager.ScoreArray.Length);
    }



}