using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour_Application : MonoBehaviour
{
    public GameObject ColourChangeParticleEffect;
    private Renderer Rend;

    void Start()
    {
        Rend = GetComponent<Renderer>();
        Rend.material.color = Color.black;
    }

    void OnMouseDown()
    {
        if (!Paint_Materials.Instance.Blue.activeSelf)
        {
            Instantiate(ColourChangeParticleEffect, transform.position, transform.rotation);
            Rend.material.color = Paint_Materials.Instance.SelectedColour;
        }
    }
}                                                                                                                               
