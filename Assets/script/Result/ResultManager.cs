﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneGlobalVariables;
using UnityEngine.UI;


public class ResultManager : MonoBehaviour
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
    
    public const int ScoreCount = 5;
    float[] ScoreArray = new float[ScoreCount];//保存するデータ

    // Use this for initialization
    void Start()
    {
        GageBlue.fillAmount = 0;
        GageRed.fillAmount = 0;

        //スコアの取得
        GetScore();

        //スコアの表示
        SetGameName();
        DisplayData();

        Score.HighScore();
    }
    // Update is called once per frame
    void Update()
    {
        //ゲージの表示
        if (ScoreArray[2] / 100 > GageBlue.fillAmount)
            GageBlue.fillAmount += 1.0f / time * Time.deltaTime;

        if (ScoreArray[4] / 100 > GageRed.fillAmount)
            GageRed.fillAmount += 1.0f / time * Time.deltaTime;
    }

    private void SetGameName()
    {
        GameName.text = GameMode.GetGameName();
    }

    private void DisplayData()
    {
        answer.text = ScoreArray[0].ToString();
        Notanswer.text = ScoreArray[1].ToString();
        Answerrate.text = ScoreArray[2].ToString() + "%";
        Averagetime.text = ScoreArray[3].ToString("f2") + "s";
    }

    private void GetScore()
    {
        ScoreArray[0] = Score.GetAnswer();
        ScoreArray[1] = Score.GetNotAnswer();
        ScoreArray[2] = Score.GetAnswerRate();
        ScoreArray[3] = Score.GetAverageTime();
        ScoreArray[4] = Score.GetNotAnswerRate();
    }
}
