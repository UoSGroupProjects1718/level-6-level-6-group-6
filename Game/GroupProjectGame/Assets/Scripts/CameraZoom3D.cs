using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom3D : MonoBehaviour
{

    public int cameraZoom;//This variable is used for the value of how far the camera should zoom in for. 
    public int cameraNormal;//This variable is used as a value to allow the camera to back out to it's original distance. 
    public float cameraSmooth;//This variable is used a value to smooth transistioning of the zoom. 

    private bool isZoomed; 

	void Start ()
    {
        isZoomed = false;
	}
	void Update ()
    {
        ZoomFunction(); 
	}

    void ZoomFunction()
    {
        if (Input.GetMouseButtonDown(1))
        {
            isZoomed = !isZoomed; 
        }

        if (isZoomed)
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, cameraZoom, Time.deltaTime * cameraSmooth);
            /*
             The line of code above, gets the main camera componment and makes it equal to a Mathf.lerp which allows a smooth transistion between 
             certain values, so the main camera componments field of view vaule will smoothly calculate with cameraZoom value while the cameraSmooth
             value is being times by Time.Deltatime to move the set value of cameraSmooth every frame. 
            */

        }
        else 
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, cameraNormal, Time.deltaTime * cameraSmooth);
            /*
            The line of code above, does the same as the previous but replaces the cameraZoom value with the cameraNormal value to allow it to
            zoom back out to it's original field of view. 
           */
        }
    } 


    
}
