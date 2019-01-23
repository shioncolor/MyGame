using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneGlobalVariables;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour {

    [SerializeField]
    private Text answer;
    [SerializeField]
    private Text Notanswer;
    [SerializeField]
    private Text Answerrate;
    [SerializeField]
    private Text Averagetime;


    string RetryButton = "Retry";
    string ReturnButton = "Return";
    string ShareButton = "Share";


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (GlobalVariables.Instance.touch.JugeObjctName(RetryButton))
        {
            
            GlobalVariables.Instance.activeManager.ChangActive(ActiveManager.GameStatus.Tutorial);
        }
        else if(GlobalVariables.Instance.touch.JugeObjctName(ReturnButton))
        {
            GlobalVariables.Instance.activeManager.ChangActive(ActiveManager.GameStatus.Title);
        }
        else if (GlobalVariables.Instance.touch.JugeObjctName(ShareButton))
        {
           
        }
    }
}
