using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour2D : MonoBehaviour {

    private static ChangeColour2D instance; 
    private Color colourSelected; 
    public Color SelectedColour { get { return colourSelected; } }

    public static ChangeColour2D Instance { get { return instance; } }

    public ParticleSystem ColourSelectedParticleEffect;
   

    void Awake()
    {
        if(Instance == null)
        {
            instance = this; 
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

    public void ChangeColourDarkRed()
    {
        colourSelected = new Color(0.5f, 0f, 0f, 1);
        Debug.Log("You have selected red");
        
    }

    public void ChangeColourBlue()
    {
        colourSelected = Color.blue;
        Debug.Log("You have selected blue");
        
    }

    public void ChangeColourDarkBlue()
    {
        colourSelected = new Color(0f, 0f, 0.5f, 1);
        Debug.Log("You have selected blue");
        
    }

    public void ChangeColourGreen()
    {
        colourSelected = Color.green;
        Debug.Log("You have selected Green");
    }

    public void ChangeColourDarkGreen()
    {
        colourSelected = new Color(0f, 0.5f, 0f, 1);
        Debug.Log("You have selected blue");        
        
    }
}
