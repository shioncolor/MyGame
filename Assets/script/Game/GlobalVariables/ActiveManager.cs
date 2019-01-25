using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveManager : MonoBehaviour
{

    public enum GameStatus
    {
        Tutorial,
        MainGame,
        GameOver,
        Result
    }

    [SerializeField]
    private GameObject Title;
    [SerializeField]
    private GameObject Tutorial;
    [SerializeField]
    private GameObject MainGame;
    [SerializeField]
    private GameObject GameOver;

    private GameObject ActiveObj;

    void Start()
    {
        ActiveObj = Tutorial;
    }

    //移行したいゲームモードが引数
    public void ChangeActive(GameStatus gameStatus)
    {
        switch (gameStatus)
        {
            case GameStatus.Tutorial:
                ActiveObj.SetActive(false);
                Tutorial.SetActive(true);
                ActiveObj = Tutorial;
                break;

            case GameStatus.MainGame:
                ActiveObj.SetActive(false);
                MainGame.SetActive(true);
                ActiveObj = MainGame;
                break;

            case GameStatus.GameOver:
                ActiveObj.SetActive(false);
                GameOver.SetActive(true);
                ActiveObj = GameOver;
                break;

            default:
                break;
        }
    }
    
}
