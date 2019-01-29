using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData{

    //正解回数
    public float Answer;

    //不正解回数
    public float NotAnswer;

    //回答時間
    public float AnswerTime;


    //平均回答時間
    public float GetAverageTime()
    {
       var AverageTime = AnswerTime / Answer;
        if (AverageTime > 0.0f)
        {
            return AverageTime;
        }
        return 0;
    }

    //正解率
    public float GetNotAnswerRate()
    {
       var NotAnswerRate = NotAnswer / (Answer + NotAnswer) * 100;
        if (NotAnswerRate > 0.0f)
        {
            return Mathf.Round(NotAnswerRate);
        }
        return 0;
    }

    //不正解率
    public float GetAnswerRate()
    {
       var AnswerRate = Answer / (Answer + NotAnswer) * 100;
        if (AnswerRate > 0.0f)
        {
            return Mathf.Round(AnswerRate);
        }
        return 0;
    }
}
