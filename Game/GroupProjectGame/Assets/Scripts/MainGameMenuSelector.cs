using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGameMenuSelector : MonoBehaviour
{
    bool MenuActive = false;
    public GameObject go;
    public Transform Target;

    void Update ()
    {
        if ((MenuActive) && (go.transform.position.x >= 105))
        {
            //Debug.Log("Moving Left");
            go.transform.Translate(Vector3.left * 1f);
        }

        if ((!MenuActive) && (go.transform.position.x <= 160))
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
