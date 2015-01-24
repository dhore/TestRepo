using UnityEngine;
using System.Collections;

public class GUI_Camera : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		camera.rect = new Rect(0f, 0.72f, 0.12f, 0.28f);
	}
}
