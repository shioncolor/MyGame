using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine;
using System;


[System.Serializable]
public class Score
{
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
    private static float AnswerRate;
    public static float GetAnswerRate()
    {
        AnswerRate = Answer / (Answer + NotAnswer) * 100;
        if (AnswerRate > 0.0f)
        {
            return Mathf.Round(AnswerRate);
        }

        return 0;
    }

    //不正解率
    private static float NotAnswerRate;
    public static float GetNotAnswerRate()
    {
        NotAnswerRate = NotAnswer / (Answer + NotAnswer) * 100;
        if (NotAnswerRate > 0.0f)
        {
            return Mathf.Round(NotAnswerRate);
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
    private static float AverageTime;
    public static float GetAverageTime()
    {
        AverageTime = AnswerTime / Answer;
        if (AverageTime > 0.0f)
        {
            return AverageTime;
        }
        return 0;
    }
    
    public static void HighScore()
    {
       var Key = PlayerPrefabKey.GetKey((int)GameMode.GetGameType());
        var newScore = MyPlayerPrefab.GetObject<SaveData>(Key);
        if (newScore.Answer <= Answer)
            Save();
    }

    private static SaveData saveData = new SaveData();
    private static void Save()
    {
        var Key = PlayerPrefabKey.GetKey((int)GameMode.GetGameType());
        saveData.Answer = Answer;
        saveData.NotAnswer = NotAnswer;
        saveData.AnswerTime = AnswerTime;
        MyPlayerPrefab.SetObject(Key, saveData);
        PlayerPrefs.Save();
    }

    public static void Reset()
    {
        Answer = 0;
        NotAnswer = 0;
        AnswerTime = 0;
    }
}
