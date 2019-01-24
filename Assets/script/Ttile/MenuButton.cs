using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    [SerializeField]
    private GameObject GameSelect;
    [SerializeField]
    private GameObject MyPage;

    public void GameSelectButtonPush()
    {
        GameSelect.SetActive(true);
        MyPage.SetActive(false);
    }

    public void MyPageButtonPush()
    {
        GameSelect.SetActive(false);
        MyPage.SetActive(true);
    }
}
