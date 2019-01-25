using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine;
using System;

public class Score
{ 

    void Start()
    {
        
    }

    //正解回数
    private static float Answer;
    public static void SetAnswer(float value)
    {
        Answer += value;
    }
    public static float GetAnswer()
    {
        return Answer;

    }


    //不正解回数
    private static float NotAnswer;
    public static void SetNotAnswer(float value)
    {
        NotAnswer += value;
    }
    public static float GetNotAnswer()
    {
        return NotAnswer;

    }

    //正解率
    public static float GetAnswerRate()
    {
        if (Answer / (Answer + NotAnswer) * 100 > -1)
        {
            return Mathf.Round(Answer / (Answer + NotAnswer) * 100);
        }

        return 0;
    }

    //不正解率
    public static float GetNotAnswerRate()
    {
        if (NotAnswer / (Answer + NotAnswer) * 100 > -1)
        {

            return Mathf.Round(NotAnswer / (Answer + NotAnswer) * 100);
        }
        return 0;
    }

    //回答時間
    private static float AnswerTime;
    public static void SetAnswerTime(float value)
    {
        AnswerTime = value; 
    }

    //平均回答時間
    public static float GetAverageTime()
    {
        if (AnswerTime / Answer > 0.01)
        {
            return AnswerTime / Answer;
        }

        return 0; 
    }

    private static  int Key;//ゲームモードのint
    private static float[] HighScore = new float[Enum.GetNames(typeof(GameMode.GameType)).Length];
    public static void SetHighScore(float value)
    {
        Key = (int)GameMode.GetGameType();
        HighScore[Key] = value;
    }
    public static bool GetHighScore(float newScore)
    {
        Key = (int)GameMode.GetGameType();
        if (HighScore[Key] <= newScore)
            return true;

        return false;
    }

    public static void Reset()
    {
        Answer = 0.0f;
        NotAnswer = 0.0f;
        AnswerTime = 0.0f;
    }
}
