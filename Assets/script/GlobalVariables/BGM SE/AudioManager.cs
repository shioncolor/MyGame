using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    private static AudioSource audioSource;

    [SerializeField]
    private GameObject BGM;

    [SerializeField]
    private GameObject ClickSE;
    private static AudioClip _ClicSE;
    [SerializeField]
    private GameObject NotCorrect;
    private static AudioClip _NotCorrect;

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        audioSource = BGM.GetComponent<AudioSource>();
        _ClicSE = ClickSE.GetComponent<AudioSource>().clip;
        _NotCorrect = NotCorrect.GetComponent<AudioSource>().clip;

        PlayBGM();
    }

    
    private static void PlayBGM()
    {
        audioSource.Play();
    }
    public static void PlayClickSE()
    {
        audioSource.PlayOneShot(_ClicSE);
    }
    public static void PlayNotCorrect()
    {
        audioSource.PlayOneShot(_NotCorrect);
    }
}
