using UnityEngine;
using System.Collections;

public class Bullet_Collision_Handler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Debug.Log("Script Loaded");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision coll)
	{
		//Debug.Log("Collision Detected");
		if(coll.transform.tag == "Wall")
		{
			//Debug.Log("Hit Wall");
			Destroy(this.gameObject);
			//Debug.Log("Bullet Destroyed");
		}
		else if(coll.transform.tag == "Ghost")
		{
			Destroy(this.gameObject);
			Destroy(coll.gameObject);

			// Increase number on GUI (handled by Script on Pacman as bullets constantly de-spawn)
			GameObject.FindWithTag("Player").GetComponent<Pacman_Ghost_CollisionHandler>().AnotherGhostShot();
		}
	}
}
