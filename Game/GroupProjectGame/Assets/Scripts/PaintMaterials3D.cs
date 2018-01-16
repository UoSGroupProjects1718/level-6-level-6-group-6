using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintMaterials3D : MonoBehaviour
{

    private static PaintMaterials3D instance;
    private Color colourSelected;
    public Color SelectedColour { get { return colourSelected; } }

    public static PaintMaterials3D Instance { get { return instance; } }

    public ParticleSystem ColourSelectedParticleEffect;

    void Awake()
    {
        if (Instance == null)
        {
            instance = this;
        }
        else if (Instance != this)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

    }

    void Start()
    {
        colourSelected = Color.grey;
        GetComponent<Renderer>().material.color = colourSelected;
    }

    public void ChangeColourRed()
    {
        colourSelected = Color.red;
        Debug.Log("You have selected red");

    }

    public void ChangeColourDarkRed()
    {
        colourSelected = new Color(1.78f, 0.90f, 1.34f, 1.0f);
        Debug.Log("You have selected red");

    }

    public void ChangeColourBlue()
    {
        colourSelected = new Color(1.48f, 2.12f, 2.55f, 1.0f);
        Debug.Log("You have selected blue");

    }

    public void ChangeColourDarkBlue()
    {
        colourSelected = new Color(0.80f, 1.67f, 2.55f, 1.0f);
        Debug.Log("You have selected blue");

    }

    public void ChangeColourGreen()
    {
        colourSelected = new Color(1.86f, 2.55f, 1.79f, 1.0f);
        Debug.Log("You have selected Green");
    }

    public void ChangeColourDarkGreen()
    {
        colourSelected = new Color(1.12f, 1.52f, 1.16f, 1.0f);
        Debug.Log("You have selected blue");

    }
}
