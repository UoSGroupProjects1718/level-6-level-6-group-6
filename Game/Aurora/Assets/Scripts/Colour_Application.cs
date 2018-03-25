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

    //Colouring Particle Effects 
    public GameObject butterFlyParticleEffect;
    public GameObject leafParticleEffect;
    public GameObject stoneParticleEffect;
    public GameObject woodParticleEffect;
    public GameObject waterParticleEffect; 

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
            //Instantiate(ColourChangeParticleEffect, transform.position, transform.rotation);

            ParticleEffctSystem(); 

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

    public void ParticleEffctSystem()
    {
        if(gameObject.tag == "ButterFly")
        {
            Instantiate(butterFlyParticleEffect, transform.position, transform.rotation);
        }else if(gameObject.tag == "Leaf")
        {
            Instantiate(leafParticleEffect, transform.position, transform.rotation);
        }else if(gameObject.tag == "Stone")
        {
            Instantiate(stoneParticleEffect, transform.position, transform.rotation);
        }else if(gameObject.tag == "Wood")
        {
            Instantiate(woodParticleEffect, transform.position, transform.rotation);
        }else if(gameObject.tag == "Water")
        {
            Instantiate(waterParticleEffect, transform.position, transform.rotation);
        }
    }
}                                                                                                                               
