using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Touch : MonoBehaviour
{

    private RaycastHit2D hit;
    private Vector2 TouchPos;

    [SerializeField]
    private GameObject[] PlayerHand;

    // Use this for initialization
    void Start()
    {

    }

    public bool JudgeObjctName(string ObjctName)
    {
        if (Input.GetMouseButtonUp(0))
        {
            TouchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//タッチした場所
            hit = Physics2D.Raycast(TouchPos, Vector2.zero);//タッチした位置のオブジェクトを取得

            if (hit && hit.collider.gameObject.name == ObjctName)
            {
                return true;
            }
        }

        return false;
    }

    public int SelectHand()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TouchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//タッチした場所
            hit = Physics2D.Raycast(TouchPos, Vector2.zero);//タッチした位置のオブジェクトを取得

            if (hit)
            {
                switch (hit.collider.gameObject.name)
                {
                    case "gu":
                        PlayerHand[0].transform.DOScale(new Vector3(0.45f, 0.45f), 0.1f);//押したらボタンが動く
                        PlayerHand[0].transform.DOScale(new Vector3(0.4f, 0.4f), 0.1f);
                        return 0;
                    case "tyoki":
                        PlayerHand[1].transform.DOScale(new Vector3(0.45f, 0.45f), 0.1f);
                        PlayerHand[1].transform.DOScale(new Vector3(0.4f, 0.4f), 0.1f);
                        return 1;
                    case "pa":
                        PlayerHand[2].transform.DOScale(new Vector3(0.5f, 0.5f), 0.1f);
                        PlayerHand[2].transform.DOScale(new Vector3(0.45f, 0.45f), 0.1f);
                        return 2;
                }
            }
        }

        return 3;
    }
}
