using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGameMenuSelector : MonoBehaviour
{
    bool MenuActive = false;
    public GameObject go;
    public Transform Target;
    private GameObject ThisGo;
    private GameObject GameMan;
    private PaintMaterials3D Paint;

    void Start()
    {
        ThisGo = this.gameObject;
        GameMan = GameObject.Find("GameManager");
        Paint = GameMan.GetComponent<PaintMaterials3D>();
    }

    void Update ()
    {
        if ((MenuActive) && (go.transform.position.x >= (ThisGo.transform.position.x - 1)))
        {
            go.transform.Translate(Vector3.left * 10f);
        }

        if ((!MenuActive) && (go.transform.position.x <= (ThisGo.transform.position.x + 250)))
        {
            Paint.ResetColours();
            go.transform.Translate(Vector3.right * 10f);
        }
    }

	public void OnClick ()
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
