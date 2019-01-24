using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneGlobalVariables;

public class TutorialButton : MonoBehaviour {

	public void ButtonPush()
    {
        GlobalVariables.Instance.activeManager.ChangeActive(ActiveManager.GameStatus.MainGame);
    }
}
