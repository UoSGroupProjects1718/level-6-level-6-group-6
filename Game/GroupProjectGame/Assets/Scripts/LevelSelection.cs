using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelection : MonoBehaviour {

    private SceneManagement ScenemanScript;
    private GameObject GameController;
    public float IslandLevel;
    public GameObject ThisGo;

	void Start ()
    {
        GameController = GameObject.Find("Scene_Manager");
        ScenemanScript = GameController.GetComponent<SceneManagement>();

        GetComponent<SpriteRenderer>().color = Color.grey;
    }
	
	void Update ()
    {
        if ((ThisGo == GameObject.Find("Island_1")) && Input.GetMouseButton(0))
        {
            ScenemanScript.CurrentScene = 2;
        }
    }

    void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
        ThisGo = this.gameObject;
    }

    void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = Color.grey;
        ThisGo = null;
    }

}
