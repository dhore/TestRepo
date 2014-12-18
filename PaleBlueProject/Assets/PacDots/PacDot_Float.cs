using UnityEngine;
using System.Collections;

public class PacDot_Float : MonoBehaviour {

	float speed = 0.5f;
	float timer = 0.75f;
	bool down = true;


	// Update is called once per frame
	void Update ()
	{
		timer -= Time.deltaTime;
		if (timer <= 0)
		{
			down = !down;
			timer = 0.75f;
		}
	
		if (down == true)
			transform.Translate(0, -speed*Time.deltaTime, 0);
		else
			transform.Translate(0, speed*Time.deltaTime, 0);
	}

	void OnCollisionEnter (Collision coll)
	{
		if (coll.transform.tag == "Player")
			Destroy (this.gameObject);
	}
}
