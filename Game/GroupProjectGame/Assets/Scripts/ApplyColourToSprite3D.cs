using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyColourToSprite3D : MonoBehaviour {

    public GameObject ColourChangeParticleEffect;
    private Renderer Rend;

    void Start ()
    {
        Rend = GetComponent<Renderer>();
    }

    void OnMouseDown ()
    {
        Instantiate(ColourChangeParticleEffect, transform.position, transform.rotation);
        Rend.material.color = PaintMaterials3D.Instance.SelectedColour;
    }
}
