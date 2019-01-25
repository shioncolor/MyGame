using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using SceneGlobalVariables;
using System;

[RequireComponent(typeof(PlayerMove))]
[RequireComponent(typeof(EnemyMove))]
[RequireComponent(typeof(Judge))]
public class MainGameManager : MonoBehaviour
{
    public PlayerMove playerMove { get { return this.pMove ?? (this.pMove = GetComponent<PlayerMove>()); } }
    PlayerMove pMove;
    public EnemyMove enemyMove { get { return this.eMove ?? (this.eMove = GetComponent<EnemyMove>()); } }
    EnemyMove eMove;
    public Judge judge { get { return this.Judge ?? (this.Judge = GetComponent<Judge>()); } }
    Judge Judge;

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

    // Use this for initialization
    void Start()
    {
        NowTime = 0.0f;
        AnswerTime = 0.0f;
        gameMode = GameMode.play;
    }

    // Update is called once per frame
    void Update()
    {
        Timar();

        if (NowTime >= TimeRimit)
        {
            GameOver();
        }

        if (gameMode == GameMode.play)
        {
            playerMove.CheckPlayerHand();//選択したplayerの手を取得

            if (playerMove.SelectPlayerHand != 3)
            {
                //じゃんけんに勝ったかどうか
                if (judge.IsJudge(playerMove.SelectPlayerHand,enemyMove.EnemyHand, (int)enemyMove.handColor))
                {
                    gameMode = GameMode.enemySelect;
                    Score.SetAnswer(1.0f);
                    Score.SetAnswerTime(NowTime - AnswerTime);
                    AnswerTime = NowTime;
                }
                else
                {
                    enemyMove.Flash();
                    Score.SetNotAnswer(1.0f);
                }
            }

        }

        if (gameMode == GameMode.enemySelect)
        {
            enemyMove.SelectEnemyHand();//enemyの手を選択
            enemyMove.Flash();
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
