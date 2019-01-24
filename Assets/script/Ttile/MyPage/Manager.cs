﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    [SerializeField]
    private Text answer;
    [SerializeField]
    private Text Notanswer;
    [SerializeField]
    private Text Answerrate;
    [SerializeField]
    private Text Averagetime;
    [SerializeField]
    private Text GameName;
    [SerializeField]
    private Image GageBlue;
    [SerializeField]
    private Image GageRed;

    private float time = 2.0f;
    private const int ScoreCount = 5;

    public static float[] ScoreArray = new float[ScoreCount];
    public static int Key;//読み込んだゲームキーの番号
    public bool flag = true;//表示するデータが更新されたかどうか

    void Start()
    {
        Key = 0;

        ScoreArray = PlayerPrefsX.GetFloatArray(PlayerPrefabKey.GetKey(0), 0, ScoreArray.Length);
        answer.text = ScoreArray[0].ToString();
        Notanswer.text = ScoreArray[1].ToString();
        Answerrate.text = ScoreArray[2].ToString() + "%";
        Averagetime.text = ScoreArray[3].ToString("f2") + "s";
        GageBlue.fillAmount = ScoreArray[2] / 100;
        GageRed.fillAmount = ScoreArray[4] / 100;
    }

    void Update()
    {

        switch (Key)
        {
            case 0:
                GameName.text = "後出しじゃんけん";
                flag = true;
                break;

            case 1:
                GameName.text = "Test";
                break;

            case 2:
                GameName.text = "Test";
                break;

            case 3:
                GameName.text = "Test";
                break;

            case 4:
                GameName.text = "Test";
                break;

            case 5:
                GameName.text = "Test";
                break;
        }
        answer.text = ScoreArray[0].ToString();
        Notanswer.text = ScoreArray[1].ToString();
        Answerrate.text = ScoreArray[2].ToString() + "%";
        Averagetime.text = ScoreArray[3].ToString("f2") + "s";

        GageBlue.fillAmount = ScoreArray[2] / 100;
        GageRed.fillAmount = ScoreArray[4] / 100;

    }
}