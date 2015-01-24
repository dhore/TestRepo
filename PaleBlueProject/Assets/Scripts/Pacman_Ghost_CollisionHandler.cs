using UnityEngine;
using System.Collections;

public class Pacman_Ghost_CollisionHandler : MonoBehaviour {

	int numDeaths = 0;
	int numGhostsShot = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision coll)
	{
		if(coll.transform.tag == "Ghost")
		{
			Destroy(coll.gameObject);
			transform.position = new Vector3(5f, 4.75f, -65f);
			transform.rotation = new Quaternion();
			numDeaths++;
		}
	}

	public void AnotherGhostShot()
	{
		numGhostsShot++;
	}

	void OnGUI()
	{
		// GUI for Number of Deaths
		Rect position1 = new Rect(20f, Screen.height - 120f, 200f, 30f);
		GUI.color = Color.white;
		GUI.skin.label.fontSize = 18;
		GUI.Label (position1, "Deaths: " + numDeaths.ToString());

		// GUI for Number of Ghosts Shot (handled for Bullets as they constantly de-spawn)
		Rect position2 = new Rect(20f, Screen.height - 80f, 200f, 30f);
		GUI.color = Color.white;
		GUI.skin.label.fontSize = 18;
		GUI.Label (position2, "Ghosts Shot: " + numGhostsShot.ToString());
	}
}
