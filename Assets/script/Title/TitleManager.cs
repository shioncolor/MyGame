using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneGlobalVariables;

public class TitleManager : MonoBehaviour {

    // Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
        //押されたらチュートリアルに移行
        if(Input.GetMouseButton(0))
        {
            GlobalVariables.Instance.activeManager.ChangActive(ActiveManager.GameStatus.Tutorial);
        }
	}

}
