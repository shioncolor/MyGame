using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    //正解回数
    private int answer;
    public int Answer
    {
        get { return this.answer; }
        set { this.answer += value; }
    }

    //不正解回数
    private int NotAnswer;
    public int notAnswer
    {
        get { return this.NotAnswer; }
        set { this.NotAnswer += value; }
    }

    //正解率
    private float answerRate;
    public float AnswerRate
    {
        get { return answer / (answer + NotAnswer)*100; }
    }

    //回答時間
    private float answerTime;
    public float AnswerTime
    {
        set { this.answerTime = value; }
    }

    //平均回答時間
    public float AverageTime
    {
        get { return answerTime / (answer + NotAnswer); }
    }

    
}
