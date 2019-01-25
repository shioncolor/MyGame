using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneGlobalVariables;

public class GameOver : MonoBehaviour {

    private float NowTime;
    private float NextSceneTime=5.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        NowTime += Time.deltaTime;
        //押されたらチュートリアルに移行
        if (Input.GetMouseButton(0) || NowTime>NextSceneTime)
        {
            SceneChang.Change(SceneChang.SceneState.Result);
        }
    }
}
