﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneGlobalVariables;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //押されたらチュートリアルに移行
        if (Input.GetMouseButton(0))
        {
            SceneChang.Change(SceneChang.SceneState.Result);
        }
    }
}