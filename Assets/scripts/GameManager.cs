using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameEnd = false;

	float EndSeconds = 1;

	public GameObject CompletedLevelUI;

	public void LevelComplete() {
		CompletedLevelUI.SetActive (true);
	}

	public void EndGame() {
		
		if (gameEnd == false) {
			gameEnd = true;
			Debug.Log ("End Game");
			Invoke ("RestartGame", EndSeconds);
		}
	
	}
	void RestartGame() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
