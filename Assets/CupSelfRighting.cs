using UnityEngine;
using System.Collections;

public class CupSelfRighting : MonoBehaviour {
    private bool isGrabbed;
    private bool used = false;
    private float timeSinceUse;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        isGrabbed = GetComponent<GrabbableObject>().IsGrabbed();

        if (isGrabbed)
        {
            used = true;
            timeSinceUse = Time.time;
        }
        else
        {
            if(Time.time - timeSinceUse < 2)
            {
                Debug.Log("traying to go up");

                //Determine which way is up
                //transform.rotation = Quaternion.LookRotation(Vector3.forward);
            }
        }
    }
}
