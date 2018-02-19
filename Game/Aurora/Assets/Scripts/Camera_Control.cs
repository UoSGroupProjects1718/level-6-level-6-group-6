using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    
    public GameObject CurrentIsland;
    public GameObject Hitobject;

    private Camera MainCamera;

    private Vector3 Island = new Vector3(0, 75, -113);
    private Quaternion IslandRot = Quaternion.Euler(14, 0, 0);

    private Vector3 Island2 = new Vector3(257, 122, 388);
    private Quaternion Island2Rot = Quaternion.Euler(14, -134, 0);

    private Vector3 StoredLoc;
    private Quaternion StoredRot;

    private GameObject Island_1;
    private GameObject Island_2;

    void Start()
    {
        CurrentIsland = GameObject.Find("Island_01");
        Island_1 = GameObject.Find("Island_01");
        Island_2 = GameObject.Find("Island_02");
        MainCamera = this.GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit HitObject = new RaycastHit();
            Ray Raycast = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(Raycast, out HitObject, 500f))
            {
                if ((HitObject.transform.tag == ("Island")) && (CurrentIsland != Island_1))
                {
                    StoredLoc = Island;
                    StoredRot = IslandRot;
                    CurrentIsland = Island_1;
                    StartCoroutine(CameraPan(Island2, StoredLoc, 2.5f, Island2Rot, StoredRot));
                }

                if ((HitObject.transform.tag == ("Island2")) && (CurrentIsland != Island_2))
                {
                    StoredLoc = Island2;
                    StoredRot = Island2Rot;
                    CurrentIsland = Island_2;
                    StartCoroutine(CameraPan(Island, StoredLoc, 2.5f, IslandRot, StoredRot));
                }
            }
        }
    }

    IEnumerator CameraPan(Vector3 from, Vector3 to, float time, Quaternion fromrot, Quaternion torot)
    {
        float Speed = 1 / time;
        float Percentage = 0;

        while (Percentage < 1)
        {
            Percentage += Time.deltaTime * Speed;
            MainCamera.transform.position = Vector3.Lerp(from, to, Percentage);
            MainCamera.transform.rotation = Quaternion.Lerp(fromrot, torot, Percentage);
            yield return null;
        }
    }
}
