﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using SceneGlobalVariables;
using System;

[RequireComponent(typeof(BirdViewSelectColor))]
public class BirdViewMainGame : MonoBehaviour {

    public BirdViewSelectColor _Color { get { return this._BirdViewSelectColor ?? (this._BirdViewSelectColor = GetComponent<BirdViewSelectColor>()); } }
    BirdViewSelectColor _BirdViewSelectColor;

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

    public static bool flag;//押されたときの一回だけ判定
    void Start()
    {
        gameMode = GameMode.enemySelect;
    }
    // Update is called once per frame
    void Update () {
      Timar();

        if (NowTime >= TimeRimit)
        {
            GameOver();
        }

        if(gameMode==GameMode.play && flag)
        {
            if (_Color.CheckAnswer())
            {
                Score.SetAnswer(1.0f);
                Score.SetAnswerTime(NowTime - AnswerTime);
                AnswerTime = NowTime;
                _Color.ContinuousAnswer=1;
                gameMode = GameMode.enemySelect;
            }
            else
            {
                AudioManager.PlayNotCorrect();
                _Color.ContinuousAnswer = 0;
                Score.SetNotAnswer(1.0f);
            }
            flag = false;
        }
        else if (gameMode == GameMode.enemySelect)
        {
            _Color.ChangeColor();
            gameMode = GameMode.ready;

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
