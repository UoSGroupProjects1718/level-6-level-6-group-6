using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintMaterials3D : MonoBehaviour
{

    private static PaintMaterials3D instance;
    private Color colourSelected;
    public Color SelectedColour { get { return colourSelected; } }

    public static PaintMaterials3D Instance { get { return instance; } }

    public ParticleSystem ColourSelectedParticleEffect;

    public GameObject Red;
    public GameObject DarkRed;
    public GameObject Blue;
    public GameObject DarkBlue;
    public GameObject Green;
    public GameObject DarkGreen;
    private bool MoveRed = false;
    private bool MoveDRed = false;
    private bool MoveGreen = false;
    private bool MoveDGreen = false;
    private bool MoveBlue = false;
    private bool MoveDBlue = false;

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

    public void Paint()
    {
        if (!Red.activeInHierarchy)
        {
            StartCoroutine(MoveColours());
        }
        else if (Red.activeInHierarchy)
        {
            ResetColours();
        }
    }

    IEnumerator MoveColours()
    {
        Red.SetActive(true);
        MoveRed = true;
        yield return new WaitForSeconds(0.1f);
        DarkRed.SetActive(true);
        MoveDRed = true;
        yield return new WaitForSeconds(0.1f);
        Green.SetActive(true);
        MoveGreen = true;
        yield return new WaitForSeconds(0.1f);
        DarkGreen.SetActive(true);
        MoveDGreen = true;
        yield return new WaitForSeconds(0.1f);
        Blue.SetActive(true);
        MoveBlue = true;
        yield return new WaitForSeconds(0.1f);
        DarkBlue.SetActive(true);
        MoveDBlue = true;
        yield return new WaitForSeconds(0.1f);
        MoveDBlue = false;
        MoveBlue = false;
        MoveDGreen = false;
        MoveGreen = false;
        MoveDRed = false;
        MoveRed = false;
    }

    void Update()
    {
        if(MoveRed)
        {
            Red.transform.Translate(Vector3.left * 1.75f);
        }
        if (MoveDRed)
        {
            DarkRed.transform.Translate(Vector3.left * 1.75f);
        }
        if (MoveGreen)
        {
            Green.transform.Translate(Vector3.left * 1.75f);
        }
        if (MoveDGreen)
        {
            DarkGreen.transform.Translate(Vector3.left * 1.75f);
        }
        if (MoveBlue)
        {
            Blue.transform.Translate(Vector3.left * 1.75f);
        }
        if (MoveDBlue)
        {
            DarkBlue.transform.Translate(Vector3.left * 1.75f);
        }
    }

    public void Eraser()    
    {
        colourSelected = Color.white;
    }

    public void Exit()
    {

    }

    public void ResetColours()
    {
        Blue.SetActive(false);
        Blue.transform.localPosition = new Vector3(0,0,0);
        DarkBlue.SetActive(false);
        DarkBlue.transform.localPosition = new Vector3(0, 0, 0);
        Green.SetActive(false);
        Green.transform.localPosition = new Vector3(0, 0, 0);
        DarkRed.SetActive(false);
        DarkRed.transform.localPosition = new Vector3(0, 0, 0);
        Red.SetActive(false);
        Red.transform.localPosition = new Vector3(0, 0, 0);
        DarkGreen.SetActive(false);
        DarkGreen.transform.localPosition = new Vector3(0, 0, 0);
    }

    public void ChangeColourRed()
    {
        colourSelected = Color.red;
        Debug.Log("You have selected red");
        ResetColours();
    }

    public void ChangeColourDarkRed()
    {
        colourSelected = new Color(1.78f, 0.90f, 1.34f, 1.0f);
        Debug.Log("You have selected red");
        ResetColours();
    }

    public void ChangeColourBlue()
    {
        colourSelected = new Color(1.48f, 2.12f, 2.55f, 1.0f);
        Debug.Log("You have selected blue");
        ResetColours();
    }

    public void ChangeColourDarkBlue()
    {
        colourSelected = new Color(0.80f, 1.67f, 2.55f, 1.0f);
        Debug.Log("You have selected blue");
        ResetColours();
    }

    public void ChangeColourGreen()
    {
        colourSelected = new Color(1.86f, 2.55f, 1.79f, 1.0f);
        Debug.Log("You have selected Green");
        ResetColours();
    }

    public void ChangeColourDarkGreen()
    {
        colourSelected = new Color(1.12f, 1.52f, 1.16f, 1.0f);
        Debug.Log("You have selected blue");
        ResetColours();
    }
}
