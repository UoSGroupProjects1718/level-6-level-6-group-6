using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoard2D : MonoBehaviour {

    public Camera sceneCamera; 
	
	void Start () {
        sceneCamera = Camera.main; 
	}
	
	
	void Update () {
        Vector3 rot = sceneCamera.transform.rotation.eulerAngles;

        rot.x = 0;
        rot.z = 0;
        transform.rotation = Quaternion.Euler(rot); 
	}
}
