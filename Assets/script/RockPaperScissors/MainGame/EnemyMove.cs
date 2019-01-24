using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;
using SceneGlobalVariables;
using UnityEngine;
using System;

public class EnemyMove : MonoBehaviour
{

    public enum HandColor
    {
        Red = 1,
        Bule
    }
    public HandColor handColor;

    [SerializeField]
    private GameObject[] Hands;

    //objactのorder in layerを変えて表示非表示 2=表示 0=非表示
    private int ActiveSortingOrder = 2;
    private int DisableSortingOrder = 0;

    private int num;//ランダム
    private int OldNum;
    private int enemyHand;//エネミーの出した手
    public int EnemyHand
    {
        get { return enemyHand; }
    }

    private void Start()
    {
        handColor = HandColor.Bule;
        enemyHand = 0;
        OldNum = 0;
    }

    public void SelectEnemyHand()
    {
        num = UnityEngine.Random.Range(0, 5);
        enemyHand = num % 3;
        if (num >= 3)
        {
            handColor = HandColor.Red;
        }
        else
        {
            handColor = HandColor.Bule;
        }

        //order in layerを変えてアクティブの変更
        Hands[OldNum].GetComponent<SpriteRenderer>().sortingOrder = DisableSortingOrder;
        Hands[num].GetComponent<SpriteRenderer>().sortingOrder = ActiveSortingOrder;

        //今出している手を保存
        OldNum = num;
    }

    //手の点滅処理
    public void Flash()
    {
        Hands[num].GetComponent<SpriteRenderer>().sortingOrder = DisableSortingOrder;

        StartCoroutine(Delay(0.02f, () =>
        {
            Hands[num].GetComponent<SpriteRenderer>().sortingOrder = ActiveSortingOrder;
        }));
    }

    private IEnumerator Delay(float waitTime, Action action)
    {
        yield return new WaitForSeconds(waitTime);
        action();
    }
}
