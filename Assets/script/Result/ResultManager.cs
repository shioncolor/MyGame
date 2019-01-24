using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneGlobalVariables;
using UnityEngine.UI;


public class ResultManager : MonoBehaviour
{

    [SerializeField]
    private Text answer;
    [SerializeField]
    private Text Notanswer;
    [SerializeField]
    private Text Answerrate;
    [SerializeField]
    private Text Averagetime;
    [SerializeField]
    private Text GameName;
    [SerializeField]
    private Image GageBlue;
    [SerializeField]
    private Image GageRed;
    private float time = 2.0f;

    // Use this for initialization
    void Start()
    {
        SetGameName();
        answer.text = Score.GetAnswer().ToString();
        Notanswer.text = Score.GetNotAnswer().ToString();
        Answerrate.text = Score.GetAnswerRate().ToString() + "%";
        Averagetime.text = Score.GetAverageTime().ToString("f2") + "s";
        GageBlue.fillAmount = 0;
        GageRed.fillAmount = 0;

    }
    // Update is called once per frame
    void Update()
    {
        if (Score.GetAnswerRate() / 100 > GageBlue.fillAmount)
            GageBlue.fillAmount += 1.0f / time * Time.deltaTime;

        if (Score.GetNotAnswerRate() / 100 > GageRed.fillAmount)
            GageRed.fillAmount += 1.0f / time * Time.deltaTime;
    }

    private void SetGameName()
    {
        switch (GameMode.GetGameType())
        {
            case GameMode.GameType.RockPaperScissors:
                GameName.text = "後出しじゃんけん";
                break;
        }
    }
}
