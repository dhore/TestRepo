using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class ContinueForward : MonoBehaviour {

	public bool forwardStop = true;
	float forwardDelay = 3.0f;
	float speed = 10.0f;
	int numDotsCollected = 0;

	// Custom GUI Style
	GUIStyle PlayerWinGUI = new GUIStyle();

	void Start () {
		PlayerWinGUI.alignment = TextAnchor.MiddleCenter;
		PlayerWinGUI.fontSize = 50;
		PlayerWinGUI.normal.textColor = Color.green;
	}

	// Update is called once per frame
	void Update () {
	
		if (forwardStop == false)
			forwardDelay -= Time.deltaTime;

		if (forwardDelay <= 0.0f)
			transform.Translate(0, 0, speed*Time.deltaTime);
	}

	void OnTriggerEnter (Collider coll) {
	
		if (coll.transform.tag == "PacDot")
		{
		    Destroy (coll.gameObject);
			audio.Play();
			numDotsCollected++;
		}
	}

	void OnGUI()
	{
		// GUI for Number of PacDots Collected
		Rect position = new Rect(20f, Screen.height - 40f, 300f, 30f);
		GUI.color = Color.white;
		GUI.skin.label.fontSize = 18;
		GUI.skin.label.alignment = TextAnchor.LowerLeft;
		GUI.Label (position, "Dots Collected: " + numDotsCollected.ToString() + " / 172");

		// Tell Player if they Win
		if(numDotsCollected >= 172)
		{
			Rect posWin = new Rect(Screen.width / 2f - 250f, Screen.height - 80f, 500f, 80f);
			GUI.Label (posWin, "YOU WIN!", PlayerWinGUI);
		}
	}
}