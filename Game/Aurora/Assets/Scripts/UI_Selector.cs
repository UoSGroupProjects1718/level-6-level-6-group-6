using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Selector : MonoBehaviour
{
    public bool MenuActive = false;
    private GameObject go;
    private GameObject ThisGo;
    private GameObject GameMan;
    private Paint_Materials Paint;

    void Start()
    {
        ThisGo = this.gameObject;
        GameMan = GameObject.Find("Game_Manager");
        go = GameObject.Find("UI_Menu");
        Paint = GameMan.GetComponent<Paint_Materials>();
    }

    void Update()
    {
        if ((MenuActive) && (go.transform.position.x >= (ThisGo.transform.position.x - 1)))
        {
            go.transform.Translate(Vector3.left * 25f);
        }

        if ((!MenuActive) && (go.transform.position.x <= (ThisGo.transform.position.x + 400)))
        {
            Paint.ResetColours();
            go.transform.Translate(Vector3.right * 25f);
        }
    }

    public void OnClick()
    {
        if (!MenuActive)
        {
            MenuActive = true;
        }
        else if (MenuActive)
        {
            MenuActive = false;
        }
    }
}
