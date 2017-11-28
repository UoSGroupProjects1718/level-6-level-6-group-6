using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour {

    public float CurrentScene = 0;

	void Awake ()
    {
        DontDestroyOnLoad(transform.gameObject);
	}
	
	void Update ()
    {
        if (CurrentScene == 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                CurrentScene = 1;
                SceneManager.LoadScene("Level_Selector", LoadSceneMode.Single);
            }
        }

        if (CurrentScene == 2)
        {
            CurrentScene = 3;
            SceneManager.LoadScene("Main_Game");
        }
	}
}
