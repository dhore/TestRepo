using UnityEngine;
using System.Collections;

public class ContinueForward : MonoBehaviour {

	public bool forwardStop = true;
	float forwardDelay = 3.0f;
	float speed = 10.0f;
	
	// Update is called once per frame
	void Update () {
	
		if (forwardStop == false)
			forwardDelay -= Time.deltaTime;

		if (forwardDelay <= 0.0f)
			transform.Translate(0, 0, speed*Time.deltaTime);
	}
}