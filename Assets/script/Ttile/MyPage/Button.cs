using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public void RockPaperScissorsButtonPush()
    {
        SetData(0);
    }

    public void CalculationButtonPush()
    {
        SetData(1);
    }

    public void BirdViewButtonPush()
    {
        SetData(2);
    }

    public void TestButtonPush()
    {
        SetData(3);
    }

    private void SetData(int Key)
    {
        Manager.Key = Key;
        MyPlayerPrefab.LoadJsonOverwrite<SaveData>(PlayerPrefabKey.GetKey(Key),Manager.saveData);
        AudioManager.PlayClickSE();
    }
}