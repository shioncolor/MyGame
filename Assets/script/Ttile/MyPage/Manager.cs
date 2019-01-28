using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
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
    private  Text GameName;
    [SerializeField]
    private Image GageBlue;
    [SerializeField]
    private Image GageRed;


    public static float[] ScoreArray = new float[ResultManager.ScoreCount];//読み込んだデータ
    public static int Key;//読み込んだゲームキーの番号
    public static string text;//読み込んだゲームの種類の名前

    void Start()
    {
        Key = 0;

        ScoreArray = PlayerPrefsX.GetFloatArray(PlayerPrefabKey.GetKey(0), 0, ScoreArray.Length);
        answer.text = ScoreArray[0].ToString();
        Notanswer.text = ScoreArray[1].ToString();
        Answerrate.text = ScoreArray[2].ToString() + "%";
        Averagetime.text = ScoreArray[3].ToString("f2") + "s";
        GageBlue.fillAmount = ScoreArray[2] / 100;
        GageRed.fillAmount = ScoreArray[4] / 100;
    }

    void Update()
    {
        GameName.text = GameMode.GetGameName(Key);
        answer.text = ScoreArray[0].ToString();
        Notanswer.text = ScoreArray[1].ToString();
        Answerrate.text = ScoreArray[2].ToString() + "%";
        Averagetime.text = ScoreArray[3].ToString("f2") + "s";

        GageBlue.fillAmount = ScoreArray[2] / 100;
        GageRed.fillAmount = ScoreArray[4] / 100;

    }
}
