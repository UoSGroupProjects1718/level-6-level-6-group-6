using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour_Application : MonoBehaviour
{
    public GameObject ColourChangeParticleEffect;
	public Material[] materials;
    private Renderer Rend;
	//private AudioSource OnClick;
	//public AudioClip Chimes;
	private GameObject GameMan;
	private Paint_Materials Paintref;
	public Material Blue;
	public Material DBlue;
	public Material DGreen;
	public Material Green;
	public Material DOrange;
	public Material Yellow;

    void Start()
    {
		GameMan = GameObject.Find("Game_Manager");
		Paintref = GameMan.GetComponent<Paint_Materials>();
        Rend = GetComponent<Renderer>();
        Rend.material.color = Color.black;
		
		//OnClick = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if (!Paintref.Blue.activeSelf)
        {
			/*if (!OnClick.isPlaying)
			{	
				OnClick.PlayOneShot(Chimes, 0.5f);
			}*/
            Instantiate(ColourChangeParticleEffect, transform.position, transform.rotation);
			
			if (Paintref.BlueSelected)
			{
				Rend.material = Blue;
				
			}	
			else if (Paintref.DarkBlueSelected)
			{
				Rend.material = DBlue;
			}
			else if (Paintref.DarkGreenSelected)
			{
				Rend.material = DGreen;
			}
			else if (Paintref.GreenSelected)
			{
				Rend.material = Green;
			}
			else if (Paintref.DarkOrangeSelected)
			{
				Rend.material = DOrange;
			}
			else if (Paintref.YellowSelected)
			{
				Rend.material = Yellow;
			}
        }
		
		if (Paintref.EraserSelected)
		{
			Rend.material.color = Color.black;
		}
    }
}                                                                                                                               
