using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneGlobalVariables;
using System;

public class PlayerMove : MonoBehaviour {

    private int selectMyHand;


    public int SelectPlayerHand
    {
        get { return this.selectMyHand; }
    }
    private void Start()
    {
        selectMyHand = 3;
    }

    public void CheckPlayerHand()
    {
        selectMyHand = GlobalVariables.Instance.touch.SelectHand();
    }

}
