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
			
			if (Paintref.ColourStorer == 1)
			{
				Rend.material = Blue;
			}	
			else if (Paintref.ColourStorer == 2)
			{
				Rend.material = DBlue;
			}
			else if (Paintref.ColourStorer == 4)
			{
				Rend.material = DGreen;
			}
			else if (Paintref.ColourStorer == 3)
			{
				Rend.material = Green;
			}
			else if (Paintref.ColourStorer == 6)
			{
				Rend.material = DOrange;
			}
			else if (Paintref.ColourStorer == 5)
			{
				Rend.material = Yellow;
			}
        }
		
		if (Paintref.ColourStorer == 0)
		{
			Rend.material.color = Color.black;
		}
    }
}                                                                                                                               
