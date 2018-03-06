using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paint_Materials : MonoBehaviour
{
    private Color colourSelected;
    public Color SelectedColour { get { return colourSelected; } }
    public ParticleSystem ColourSelectedParticleEffect;

    [Header("Variables Used for Colour Selection")]
    public GameObject Blue;
    private GameObject DarkGreen;
    private GameObject Green;
    private GameObject DarkOrange;
    private GameObject Yellow;
    private GameObject Ice;
	private bool ColoursAssigned = false;
    private bool MoveBlue = false;
    private bool MoveDGreen = false;
    private bool MoveGreen = false;
    private bool MoveDOrange = false;
    private bool MoveYellow = false;
    private bool MoveIce = false;
    private float TranslateSpeed = 0.25f;
	private AudioSource BackgroundMusic;

	[Header("Variables Used for Changing Material Colour")]
	public bool BlueSelected = false;
	public bool DarkBlueSelected = false;
	public bool GreenSelected = false;
	public bool YellowSelected = false;
	public bool DarkOrangeSelected = false;
	public bool DarkGreenSelected = false;
	public bool EraserSelected = false;
	
    void Start()
    {
		colourSelected = Color.black;
		GetComponent<Renderer>().material.color = colourSelected;
		BackgroundMusic = GetComponent<AudioSource>();
		BackgroundMusic.Play();
    }
	
	public void AssignColours()
	{
        Blue = GameObject.Find("Blue");
        DarkGreen = GameObject.Find("DarkGreen");
		Green = GameObject.Find("Green");
		DarkOrange = GameObject.Find("DarkOrange");
		Yellow = GameObject.Find("Yellow");
		Ice = GameObject.Find("Ice");
        ResetColours();
		ColoursAssigned = true;

	}
	
    public void Paint()
    {
		BlueSelected = false;
		DarkBlueSelected = false;
		GreenSelected = false;
		YellowSelected = false;
		DarkOrangeSelected = false;
		DarkGreenSelected = false;
		EraserSelected = false;
		
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
		Scene currentScene = SceneManager.GetActiveScene();
		
		string sceneName = currentScene.name;
		
		if ((sceneName == "Main_Game") && (!ColoursAssigned))
		{
			AssignColours();
		}
		
        if (MoveBlue)
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
		EraserSelected = true;
    }

    public void Exit()
    {

    }

    public void ResetColours()
    {
        Blue.SetActive(false);
        Blue.transform.localPosition = new Vector3(0, 0, 0);
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
        BlueSelected = true;
        Debug.Log("You have selected Blue");
        ResetColours();
    }

    public void ChangeColourDarkGreen()
    {
        DarkGreenSelected = true;
        Debug.Log("You have selected Dark Green");
        ResetColours();
    }

    public void ChangeColourGreen()
    {
        GreenSelected = true;
        Debug.Log("You have selected Green");
        ResetColours();
    }

    public void ChangeColourDarkOrange()
    {
        DarkOrangeSelected = true;
        Debug.Log("You have selected Dark Orange");
        ResetColours();
    }

    public void ChangeColourYellow()
    {
        YellowSelected = true;
        Debug.Log("You have selected Yellow");
        ResetColours();
    }

    public void ChangeColourIce()
    {
        DarkBlueSelected = true;
        Debug.Log("You have selected Ice");
        ResetColours();
    }
}
