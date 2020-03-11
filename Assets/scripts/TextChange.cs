using UnityEngine.UI;
using UnityEngine;

public class TextChange : MonoBehaviour {

	public Transform player;
	public Text Scoretext;
	
	// Update is called once per frame
	void Update () {
		Scoretext.text = player.position.z.ToString("0");
	}
}
