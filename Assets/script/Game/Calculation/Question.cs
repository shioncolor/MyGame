using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine;
using System;

public class Question : MonoBehaviour
{

    private enum AnswerOperator
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }
    AnswerOperator answerOperator;

    public static int SelectAnswer;//押されたボタンの演算子

    public int value;
    public int num;
    public int Answer;

    public bool flag = true;
    public void CreateQuestion()
    {
        num = UnityEngine.Random.Range(2, 10);
        value = UnityEngine.Random.Range(2, 10);
        //演算子選択
        answerOperator= (AnswerOperator)Enum.ToObject(typeof(AnswerOperator), UnityEngine.Random.Range(0, 4));

        switch (answerOperator)
        {
            case AnswerOperator.Addition:
                Answer = value + num;
                break;
            case AnswerOperator.Subtraction:
                Answer = value - num;
                break;
            case AnswerOperator.Multiplication:
                Answer = value * num;
                break;
            case AnswerOperator.Division:
                if (value % num != 0)
                {
                    Answer = UnityEngine.Random.Range(1, 9);
                    value = num * Answer;
                }
                else
                {
                    Answer = value / num;
                }
               
                break;
        }
    }

    public bool CheckAnswer()
    {
        if ((int)answerOperator == SelectAnswer)
        {
            SelectAnswer = 4;
            return true;
        }
        else
            return false;
    }
}
