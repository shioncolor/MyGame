using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;
using SceneGlobalVariables;
using UnityEngine;
using System;
using UnityEngine.UI;

[RequireComponent(typeof(Question))]
public class CalculationGameManager : MonoBehaviour
{
    public Question question { get { return this._Question ?? (this._Question = GetComponent<Question>()); } }
    Question _Question;

    [SerializeField]
    private Text value;
    [SerializeField]
    private Text num;
    [SerializeField]
    private Text Answer;

    private enum GameMode
    {
        ready,
        play,
        enemySelect
    }
    GameMode gameMode;

    [SerializeField]
    private float TimeRimit;//時間制限
    private float NowTime;//経過時間
    private float AnswerTime;//問題が出てから正解するまでの時間

    public static bool flag;
    void Start()
    {
        flag = false;
        NowTime = 0.0f;
        AnswerTime = 0.0f;
        gameMode = GameMode.enemySelect;
    }

    // Update is called once per frame
    void Update()
    {
        Timar();

        if (NowTime >= TimeRimit)
        {
            GameOver();
        }

        if (gameMode == GameMode.play && flag)
        {
            if (question.CheckAnswer())
            {
                Score.SetAnswer(1.0f);
                Score.SetAnswerTime(NowTime - AnswerTime);
                AnswerTime = NowTime;
                gameMode = GameMode.enemySelect;
            }
            else
            {
                Score.SetNotAnswer(1.0f);
            }
            flag = false;
        }
        else if (gameMode == GameMode.enemySelect)
        {
            question.CreateQuestion();
            gameMode = GameMode.ready;

            value.text = question.value.ToString();
            num.text = question.num.ToString();
            Answer.text = question.Answer.ToString();
            StartCoroutine(Delay(0.1f, () =>
            {
                gameMode = GameMode.play;
            }));
        }

    }

    private void Timar()
    {
        NowTime += Time.deltaTime;
    }

    private void Display()
    {

    }

    private void GameOver()
    {
        GlobalVariables.Instance.activeManager.ChangeActive(ActiveManager.GameStatus.GameOver);
    }

    private IEnumerator Delay(float waitTime, Action action)
    {
        yield return new WaitForSeconds(waitTime);
        action();
    }
}
