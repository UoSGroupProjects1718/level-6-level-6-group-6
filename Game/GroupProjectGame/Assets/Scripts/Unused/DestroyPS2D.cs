using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPS2D : MonoBehaviour {

    private ParticleSystem thisParticleSystem;



    void Start()
    {
        thisParticleSystem = GetComponent<ParticleSystem>();
    }


    void Update()
    {

        if (thisParticleSystem.isPlaying)
        {
            return;
        }

        Destroy(gameObject);

    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
