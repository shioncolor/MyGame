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
    // Use this for initialization
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.DOFade(0.0f, Seconds).SetEase(EaseType).SetLoops(-1, LoopType.Yoyo);
    }

}
