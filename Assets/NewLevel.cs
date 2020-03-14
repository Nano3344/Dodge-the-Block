using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLevel : MonoBehaviour {

	public GameManager gameManager;

	void OnTriggerEnter() {
		gameManager.LevelComplete ();
	}
}
