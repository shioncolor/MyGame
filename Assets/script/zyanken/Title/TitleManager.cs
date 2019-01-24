using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneGlobalVariables;
using Glovalobjcts;
public class TitleManager : MonoBehaviour {

    // Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
        //押されたらチュートリアルに移行
        if(Input.GetMouseButtonUp(0))
        {
            GlobalVariables.Instance.activeManager.ChangeActive(ActiveManager.GameStatus.Tutorial);
        }
	}

}
