using UnityEngine;
using System.Collections;

public class ContinueForward : MonoBehaviour {

	public bool forwardStop = true;
	float forwardDelay = 3.0f;
	float speed = 10.0f;
//	float nomDelay = 0.2f;
	
	// Update is called once per frame
	void Update () {
	
		if (forwardStop == false)
			forwardDelay -= Time.deltaTime;

		if (forwardDelay <= 0.0f)
			transform.Translate(0, 0, speed*Time.deltaTime);
	}

	void OnTriggerEnter (Collider coll) {
	
//		nomDelay -= Time.deltaTime;
		if (coll.transform.tag == "PacDot")
		{
//			if (nomDelay <= 0.0f)
		    	Destroy (coll.gameObject);

		}
	}
}