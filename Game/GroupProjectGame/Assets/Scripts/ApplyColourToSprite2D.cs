using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyColourToSprite2D : MonoBehaviour {

    public GameObject ColourChangeParticleEffect;
    private SpriteRenderer SR; 

	void Start () {
        SR = GetComponent<SpriteRenderer>();
	}
	
	
	void Update () {
		
	}

    void OnMouseDown()
    {
        Instantiate(ColourChangeParticleEffect, transform.position, transform.rotation);
        SR.color = ChangeColour2D.Instance.SelectedColour;
    }
}
