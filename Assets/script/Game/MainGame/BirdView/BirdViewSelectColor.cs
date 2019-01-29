using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Linq;

public class BirdViewSelectColor : MonoBehaviour
{

    [SerializeField]
    private Image[] button;

    [SerializeField]
    Color[] btnColor;//色
    private int ColorCount = 2;//使いたい色の種類
    private int[] SelectColorCount;//何個のパネルがその色なのか

    private enum _Color
    {
        Red,
        Blue,
        Green,
    }
    _Color[] Selectcolor = new _Color[9];

    _Color AnswerColor;
    public static int SelectAnswerButton;//答えたときにおしたボタン

    int Max;//一番多い色の数
    int MaxIndex;

    const int LevelUpCount = 4;//難問連続正解したらレベルアップするか
    const int MaxColorCount = 3;//色の最大色数

    private int continuousAnswer;//連続正解した数
    public int ContinuousAnswer
    {
        get { return continuousAnswer; }
        set
        {
            if (value == 0)
                continuousAnswer = value;
            else
                continuousAnswer += value;
        }
    }
    public void ChangeColor()
    {
        SelectColorCount = Enumerable.Repeat(0, button.Length).ToArray();

        if (LevelUpCount < ContinuousAnswer && ColorCount < MaxColorCount)
        {
            ColorCount++;
            ContinuousAnswer = 0;
        }

        for (int i = 0; i < button.Length; i++)
        {
            //色の選択
            Selectcolor[i] = (_Color)Enum.ToObject(typeof(_Color), UnityEngine.Random.Range(0, ColorCount));
            switch (Selectcolor[i])
            {
                case _Color.Red:
                    button[i].color = btnColor[0];
                    SelectColorCount[0] += 1;
                    break;

                case _Color.Blue:
                    button[i].color = btnColor[1];
                    SelectColorCount[1] += 1;
                    break;

                case _Color.Green:
                    button[i].color = btnColor[2];
                    SelectColorCount[2] += 1;
                    break;
            }
        }

        Max = 0;
        for (int i = 0; i < ColorCount; i++)
        { 
            if (SelectColorCount[i] > Max)
            {
                MaxIndex = i;
                Max = SelectColorCount[i];
            }
        }

        AnswerColor = (_Color)Enum.ToObject(typeof(_Color), MaxIndex);
    }

    public bool CheckAnswer()
    {
        if (Selectcolor[SelectAnswerButton] == AnswerColor)
        {
            return true;
        }
        else
            return false;
    }
}