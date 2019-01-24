using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class Test : MonoBehaviour
{

    [SerializeField]
    private Text OldTime;
    [SerializeField]
    private Text NowTimeText;

    const string SeveTimeKEY = "SeveTime" ;
    float SeveTime;
    float NowTime;
    void Start()
    {
        SeveTime = LoadTime();

        OldTime.text = SeveTime.ToString();
        Seve();
    }


    private void Seve()
    {
        PlayerPrefs.SetFloat(SeveTimeKEY, NowTime);
        PlayerPrefs.Save();
    }

    private float LoadTime()
    {
        return PlayerPrefs.GetFloat(SeveTimeKEY, 0.0f);
    }

    void Update()
    {
        NowTime += Time.deltaTime;
        NowTimeText.text = NowTime.ToString();
    }
}
