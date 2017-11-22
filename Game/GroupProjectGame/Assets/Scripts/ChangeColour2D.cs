using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour2D : MonoBehaviour {

    private static ChangeColour2D Instance; 
    private Color colourSelected; 
    private Color SelectedColour { get { return colourSelected; } } 

   

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this; 
        }else if( Instance != this)
        {
            Destroy(this.gameObject); 
        }

        DontDestroyOnLoad(this.gameObject); 
      
    }

    void Start () {
        colourSelected = Color.grey; 
	}
	
	public void ChangeColourRed()
    {
        colourSelected = Color.red;
        Debug.Log("You have selected red"); 
    }

    public void ChangeColourBlue()
    {
        colourSelected = Color.blue;
        Debug.Log("You have selected blue");
    }

    public void ChangeColourGreen()
    {
        colourSelected = Color.green;
        Debug.Log("You have selected Green");
    }
}
