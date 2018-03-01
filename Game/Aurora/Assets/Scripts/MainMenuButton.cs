using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class MainMenuButton : MonoBehaviour
{
    public Button mainMenuButton;

	void Start ()
    {
        mainMenuButton = FindObjectOfType<Button>();
	}

    public void Click()
    {
        SceneManager.LoadScene(1);
    }
}