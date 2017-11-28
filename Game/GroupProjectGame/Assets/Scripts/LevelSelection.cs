using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelection : MonoBehaviour {

    private SceneManagement ScenemanScript;
    private GameObject GameController;
    public int IslandLevel;

	void Start ()
    {
        GameController = GameObject.Find("Scene_Manager");
        ScenemanScript = GameController.GetComponent<SceneManagement>();

        GetComponent<SpriteRenderer>().color = Color.grey;
    }
	
	void Update ()
    {
        if (IslandLevel == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ScenemanScript.CurrentScene = 2;
            }
        }
        else if (IslandLevel == 2)
        {

        }
        else if (IslandLevel == 2)
        {

        }
        else if (IslandLevel == 3)
        {

        }
        else if (IslandLevel == 4)
        {

        }
        else if (IslandLevel == 5)
        {

        }
        else if (IslandLevel == 6)
        {

        }

    }

    void OnMouseOver()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = Color.grey;
    }

}
