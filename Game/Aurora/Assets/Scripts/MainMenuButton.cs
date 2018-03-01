using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class MainMenuButton : MonoBehaviour
{
    public Button mainMenuButton;

	// Use this for initialization
	void Start ()
    {
        mainMenuButton = FindObjectOfType<Button>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Click()
    {
        Debug.Log("HI I AM.");
        SceneManager.LoadScene(1);
    }
}
