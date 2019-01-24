using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGage : MonoBehaviour {

    [SerializeField]
    private Image GageBlue;
    [SerializeField]
    private Image GageRed;

    private float time=5.0f;
    // Update is called once per frame

    public void Reset()
    {
        GageBlue.fillAmount = 0;
        GageRed.fillAmount = 0;
    }
    public void Gage(float deltaTime)
    {
        GageBlue.fillAmount += 1.0f / time * deltaTime;
        GageRed.fillAmount += 1.0f / time * deltaTime;
    }
}
