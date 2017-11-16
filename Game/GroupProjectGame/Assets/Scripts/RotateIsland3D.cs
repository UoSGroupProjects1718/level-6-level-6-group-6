using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateIsland3D : MonoBehaviour {

    public float rotationSpeed;// This variable is used to give a value to the rotation speed to the object it is applied. 

    void Start () {
		
	}
	
	
	void Update () {
		
	}

    void OnMouseDrag(){

        float rotX = Input.GetAxis("Mouse X") * rotationSpeed * Mathf.Deg2Rad;
        /*
        The line code above creates a float which get's it's value by calculating the axis of the mouseX coordinates, timesing it by the 
        value of the rotationSpeed variable, then timesing that by the function Mathf.Deg2Rad which is a constant converstion of degrees
        to radians allowing the answer from Mouse X * rotationSpeed calculation to be convertated to a radiant. 
        */
       
        

        transform.Rotate(Vector3.up, -rotX);
        /*
        The line code above uses the transfrom.rotate to apply and enable eulerAngles to the object, which is being rotated by getting the 
        the Y axis information of the vector using Vector3.up and using the value that has been calculated in float rotX as it's value to 
        to use to rotate by.
        */

       
    }
}
