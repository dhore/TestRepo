using UnityEngine;
using System.Collections;

public class WaggaWagga : MonoBehaviour {

	void OnTriggerEnter (Collider coll)
	{
		if (coll.transform.tag == "PacDot")
			Destroy (coll.gameObject);
	}
}