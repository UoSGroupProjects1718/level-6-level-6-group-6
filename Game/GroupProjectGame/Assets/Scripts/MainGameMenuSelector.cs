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

    void Start()
    {
        ThisGo = this.gameObject;
    }

    void Update ()
    {
        if ((MenuActive) && (go.transform.position.x >= (ThisGo.transform.position.x - 1)))
        {
            //Debug.Log("Moving Left");
            go.transform.Translate(Vector3.left * 1f);
        }

        if ((!MenuActive) && (go.transform.position.x <= (ThisGo.transform.position.x + 45)))
        {
            //Debug.Log("Moving Right");
            go.transform.Translate(Vector3.right * 1f);
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
