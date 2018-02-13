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
    public GameObject Blue;
    public GameObject DarkGreen;
    public GameObject Green;
    public GameObject DarkOrange;
    public GameObject Yellow;
    public GameObject Ice;

    private bool MoveBlue = false;
    private bool MoveDGreen = false;
    private bool MoveGreen = false;
    private bool MoveDOrange = false;
    private bool MoveYellow = false;
    private bool MoveIce = false;
    private float TranslateSpeed = 0.2f;

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
        if (!Blue.activeInHierarchy)
        {
            StartCoroutine(MoveColours());
        }
        else if (Blue.activeInHierarchy)
        {
            ResetColours();
        }
    }

    IEnumerator MoveColours()
    {
        Blue.SetActive(true);
        MoveBlue = true;
        yield return new WaitForSeconds(0.1f);
        DarkGreen.SetActive(true);
        MoveDGreen = true;
        yield return new WaitForSeconds(0.1f);
        Green.SetActive(true);
        MoveGreen = true;
        yield return new WaitForSeconds(0.1f);
        DarkOrange.SetActive(true);
        MoveDOrange = true;
        yield return new WaitForSeconds(0.1f);
        Yellow.SetActive(true);
        MoveYellow = true;
        yield return new WaitForSeconds(0.1f);
        Ice.SetActive(true);
        MoveIce = true;
        yield return new WaitForSeconds(0.1f);
        MoveIce = false;
        MoveYellow = false;
        MoveDOrange = false;
        MoveGreen = false;
        MoveDGreen = false;
        MoveBlue = false;
    }

    void Update()
    {
        if(MoveBlue)
        {
            Blue.transform.Translate(Vector3.left * TranslateSpeed / Time.deltaTime);
        }
        if (MoveDGreen)
        {
            DarkGreen.transform.Translate(Vector3.left * TranslateSpeed / Time.deltaTime);
        }
        if (MoveGreen)
        {
            Green.transform.Translate(Vector3.left * TranslateSpeed / Time.deltaTime);
        }
        if (MoveDOrange)
        {
            DarkOrange.transform.Translate(Vector3.left * TranslateSpeed / Time.deltaTime);
        }
        if (MoveYellow)
        {
            Yellow.transform.Translate(Vector3.left * TranslateSpeed / Time.deltaTime);
        }
        if (MoveIce)
        {
            Ice.transform.Translate(Vector3.left * TranslateSpeed / Time.deltaTime);
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
        DarkGreen.SetActive(false);
        DarkGreen.transform.localPosition = new Vector3(0, 0, 0);
        Green.SetActive(false);
        Green.transform.localPosition = new Vector3(0, 0, 0);
        DarkOrange.SetActive(false);
        DarkOrange.transform.localPosition = new Vector3(0, 0, 0);
        Yellow.SetActive(false);
        Yellow.transform.localPosition = new Vector3(0, 0, 0);
        Ice.SetActive(false);
        Ice.transform.localPosition = new Vector3(0, 0, 0);
    }

    public void ChangeColourBlue()
    {
        colourSelected = new Color(0.58f,0.83f,1,1);
        Debug.Log("You have selected Blue");
        ResetColours();
    }

    public void ChangeColourDarkGreen()
    {
        colourSelected = new Color(0.44f, 0.6f, 0.45f, 1.0f);
        Debug.Log("You have selected Dark Green");
        ResetColours();
    }

    public void ChangeColourGreen()
    {
        colourSelected = new Color(0.73f, 1, 0.7f, 1.0f);
        Debug.Log("You have selected Green");
        ResetColours();
    }

    public void ChangeColourDarkOrange()
    {
        colourSelected = new Color(1, 0.62f, 0.31f, 1.0f);
        Debug.Log("You have selected Dark Orange");
        ResetColours();
    }

    public void ChangeColourYellow()
    {
        colourSelected = new Color(0.99f, 0.85f, 0.4f, 1.0f);
        Debug.Log("You have selected Yellow");
        ResetColours();
    }

    public void ChangeColourIce()
    {
        colourSelected = new Color(0.87f, 0.94f, 1, 1.0f);
        Debug.Log("You have selected Ice");
        ResetColours();
    }
}
