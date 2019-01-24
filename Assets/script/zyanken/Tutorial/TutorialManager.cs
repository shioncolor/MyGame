﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneGlobalVariables;

public class TutorialManager : MonoBehaviour {

    string StartButton = "Start";
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //押されたらゲームに移行
        if (GlobalVariables.Instance.touch.JudgeObjctName(StartButton))
        {
            GlobalVariables.Instance.activeManager.ChangeActive(ActiveManager.GameStatus.MainGame);
        }
    }
}