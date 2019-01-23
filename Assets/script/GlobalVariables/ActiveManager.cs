using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveManager : MonoBehaviour
{

    public enum GameStatus
    {
        Title,
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
    [SerializeField]
    private GameObject Result;

    private GameObject ActveObj;

    void Start()
    {
        ActveObj = Title;
    }

    public void ChangActive(GameStatus gameStatus)
    {
        switch (gameStatus)
        {
            case GameStatus.Title:
                ActveObj.SetActive(false);
                Title.SetActive(true);
                ActveObj = Title;
                break;

            case GameStatus.Tutorial:
                Title.SetActive(false);
                Tutorial.SetActive(true);
                ActveObj = Tutorial;
                break;

            case GameStatus.MainGame:
                Tutorial.SetActive(false);
                MainGame.SetActive(true);
                ActveObj = MainGame;
                break;

            case GameStatus.GameOver:
                MainGame.SetActive(false);
                GameOver.SetActive(true);
                ActveObj = GameOver;
                break;

            case GameStatus.Result:
                GameOver.SetActive(false);
                Result.SetActive(true);
                ActveObj = Result;
                break;

            default:
                break;
        }
    }
    
}
