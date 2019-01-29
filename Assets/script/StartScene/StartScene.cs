using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class StartScene : MonoBehaviour
{

    private CanvasGroup canvasGroup;
    [SerializeField]
    private Ease EaseType;
    [SerializeField]
    private float Seconds;

    SaveData saveData = new SaveData
    {
        Answer = 0,
        NotAnswer = 0,
        AnswerTime = 0
    };

    void Start()
    {
        MyPlayerPrefab.SetObject<SaveData>("initial", saveData);
       var aa= MyPlayerPrefab.GetObject<SaveData>("initial");
        Debug.Log(aa.Answer);
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.DOFade(0.0f, Seconds).SetEase(EaseType).SetLoops(-1, LoopType.Yoyo);
    }

}
