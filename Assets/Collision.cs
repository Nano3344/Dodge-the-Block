using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

	public Movement movement;

	// Update is called once per frame
	void onCollisionEnter(Collision collision) {
		if (collision.GetComponent<Collider>().tag == "Obstacle") {
			Debug.Log ("Hit");
			movement.enabled = false;
		}
	}
}
