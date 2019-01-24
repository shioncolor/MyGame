using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{

    private bool JudgeResult;
    private int Answer;

    //勝ち負け判定

    //引数　プレイヤーの選択した手,エネミーの選択した手,エネミーの選択した手の色(int)
    public bool IsJudge(int PlayerHand, int EnemyHand, int handColor)
    {
        JudgeResult = false;
        if ((PlayerHand - EnemyHand + 3) % 3 == handColor)
        {
            JudgeResult = true;
        }

        return JudgeResult;
    }
}
