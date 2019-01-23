using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using SceneGlobalVariables;
public class MainGameManager : MonoBehaviour
{

    private enum GameMode
    {
        redy,
        play
    }

    [SerializeField]
    private GameObject GuRed;
    [SerializeField]
    private GameObject GuBlue;
    private GameObject NowHand;//今表示されている手
    private GameObject NextHand;//次表示される手

    [SerializeField]
    private float TimeRimit = 60.0f;
    private float NowTime;

    //objactのorder in layerを変えて表示非表示を
    private int ActivSortingOrder=2;
    private int DisableSortingOrder=0;

    // Use this for initialization
    void Start()
    {
        NowTime = 0.0f;
        NowHand = GuBlue;
    }

    // Update is called once per frame
    void Update()
    {

        Timar();
        if (NowTime >= TimeRimit)
        {
            GameOver();
        }
        
        //Test
        if (NowTime >= 5.0f)
        {
            if (NowHand.name== "guBlue")
            {
                GuRed.GetComponent<SpriteRenderer>().sortingOrder = ActivSortingOrder;
                GuBlue.GetComponent<SpriteRenderer>().sortingOrder = DisableSortingOrder;

                NowHand = GuRed;
            }
            else
            {
                GuRed.GetComponent<SpriteRenderer>().sortingOrder = DisableSortingOrder;
                GuBlue.GetComponent<SpriteRenderer>().sortingOrder = ActivSortingOrder;

                NowHand = GuBlue;
            }
            NowTime = 0;
        }
    }

    private void Timar()
    {
        NowTime += Time.deltaTime;
    }

    private void GameOver()
    {
        GlobalVariables.Instance.activeManager.ChangActive(ActiveManager.GameStatus.GameOver);
    }
}
