using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculationGameButton : MonoBehaviour
{

    public void AdditionButtonPush()
    {
        Question.SelectAnswer = 0;
        CalculationGameManager.flag = true;
    }

    public void SubtractionButtonPush()
    {
        Question.SelectAnswer = 1;
        CalculationGameManager.flag = true;
    }

    public void MultiplicationButtonPush()
    {
        Question.SelectAnswer = 2;
        CalculationGameManager.flag = true;
    }

    public void DivisionButtonPush()
    {
        Question.SelectAnswer = 3;
        CalculationGameManager.flag = true;
    }
}
