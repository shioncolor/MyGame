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


    public static SaveData saveData;//読み込んだデータ
    public static int Key;//読み込んだゲームキーの番号
    public static string text;//読み込んだゲームの種類の名前

    void Start()
    {
        Key = 0;
        saveData = MyPlayerPrefab.GetObject<SaveData>(PlayerPrefabKey.GetKey(0));
        Draw();
    }

    void Update()
    {
       Draw();
    }

    private void Draw()
    {
        GameName.text = GameMode.GetGameName(Key);
        answer.text = saveData.Answer.ToString();
        Notanswer.text = saveData.NotAnswer.ToString();
        Answerrate.text = saveData.GetAnswerRate().ToString() + "%";
        Averagetime.text = saveData.AnswerTime.ToString("f2") + "s";
        GageBlue.fillAmount = saveData.GetAnswerRate() / 100;
        GageRed.fillAmount = saveData.GetNotAnswerRate() / 100;
    }
}
