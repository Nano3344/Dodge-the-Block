using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public Rigidbody Rb;

	public float SideForce = 500f;
	public float StraightForce = 2000f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Rb.AddForce (0, 0, StraightForce * Time.deltaTime);
		if (Input.GetKey("d")) {
			Rb.AddForce (SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (Input.GetKey("a")) {
			Rb.AddForce (-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
	}
}
