using UnityEngine;

public class CollisionDetection : MonoBehaviour {

	public Movement movement;

	void OnCollisionEnter(Collision collisionInfo) {
		if (collisionInfo.collider.tag == "Obstacle") {
			movement.enabled = false;
		}
	}
}
