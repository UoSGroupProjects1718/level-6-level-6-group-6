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
    private float TranslateSpeed = 0.25f;
	private AudioSource BackgroundMusic;

    //ColourSelected stores all colours 1=Blue, 2=DarkBlue, 3=Green, 4=DarkGreen, 5=Yellow, 6=Orange, 0=Eraser
    public int ColourStorer = 0;
	
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
        ColourStorer = 0;
		
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
        yield return new WaitForSeconds(0.1f);
        Green.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        DarkOrange.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        Yellow.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        Ice.SetActive(true);
        yield return new WaitForSeconds(0.15f);
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
    }

    public void Eraser()
    {
        ColourStorer = 0;
    }

    public void Exit()
    {

    }

    public void ResetColours()
    {
        Blue.SetActive(false);
        Blue.transform.localPosition = new Vector3(0, 0, 0);
        DarkGreen.SetActive(false);
        Green.SetActive(false);
        DarkOrange.SetActive(false);
        Yellow.SetActive(false);
        Ice.SetActive(false);
    }

    public void ChangeColourBlue()
    {
        ColourStorer = 1;
        Debug.Log("You have selected Blue");
        ResetColours();
    }
    public void ChangeColourIce()
    {
        ColourStorer = 2;
        Debug.Log("You have selected Dark Blue");
        ResetColours();
    }

    public void ChangeColourGreen()
    {
        ColourStorer = 3;
        Debug.Log("You have selected Green");
        ResetColours();
    }

    public void ChangeColourDarkGreen()
    {
        ColourStorer = 4;
        Debug.Log("You have selected Dark Green");
        ResetColours();
    }

    public void ChangeColourYellow()
    {
        ColourStorer = 5;
        Debug.Log("You have selected Yellow");
        ResetColours();
    }

    public void ChangeColourDarkOrange()
    {
        ColourStorer = 6;
        Debug.Log("You have selected Dark Orange");
        ResetColours();
    }
}
