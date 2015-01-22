using UnityEngine;
using System.Collections;

public class Ghost_Spawning : MonoBehaviour {

	public GameObject[] ghost = new GameObject[4];
	float cooldown;
	int ghostNum = 4;

	// Use this for initialization
	void Start () {
		ResetCooldown();
	}
	
	// Update is called once per frame
	void Update () {
		if(cooldown < Time.deltaTime)
		{
			ResetCooldown();
			GameObject obj = Instantiate(ghost[ghostNum % 4]) as GameObject;
			ghostNum++;
		}
	}

	// Resets Cooldown Period
	void ResetCooldown(){
		cooldown = Time.deltaTime + 12.0f;
	}
}
