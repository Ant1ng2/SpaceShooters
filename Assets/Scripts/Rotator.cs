using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

    public int tilt;

    private Rigidbody rb;
    
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate ()
    {
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, -tilt * GetComponent<Rigidbody>().velocity.x);
	}
}
