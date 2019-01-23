using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour {

    private RaycastHit2D hit;
    private Vector2 TouchPos;

    // Use this for initialization
    void Start () {
		
	}
	
	public bool JugeObjctName(string ObjctName)
    {
        if (Input.GetMouseButton(0))
        {
            TouchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//タッチした場所
            hit = Physics2D.Raycast(TouchPos, Vector2.zero);//タッチした位置のオブジェクトを取得

            if (hit&& hit.collider.gameObject.name == ObjctName)
            {
                return true;
            }
        }

        return false;
    }
}
