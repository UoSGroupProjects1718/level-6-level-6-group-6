using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour_Application : MonoBehaviour
{
    public GameObject ColourChangeParticleEffect;
    private Renderer Rend;
	private AudioSource OnClick;
	public AudioClip Chimes;

    void Start()
    {
        Rend = GetComponent<Renderer>();
        Rend.material.color = Color.black;
		
		OnClick = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if (!Paint_Materials.Instance.Blue.activeSelf)
        {
			if (!OnClick.isPlaying)
			{	
				OnClick.PlayOneShot(Chimes, 0.5f);
			}
            Instantiate(ColourChangeParticleEffect, transform.position, transform.rotation);
            Rend.material.color = Paint_Materials.Instance.SelectedColour;
        }
    }
}                                                                                                                               
