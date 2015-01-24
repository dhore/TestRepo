using UnityEngine;
using System.Collections;

public class GUI_Camera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
	}
	
	// Update is called once per frame
	void Update () {
		camera.rect = new Rect(0f, 0.78f, 0.15f, 0.22f);
	}
}
