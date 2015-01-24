using UnityEngine;
using System.Collections;
using System.Timers;

public class Ghost_Spawning : MonoBehaviour {
	
	public GameObject ghost0;
	public GameObject ghost1;
	public GameObject ghost2;
	public GameObject ghost3;
	int ghostNum = 4;
	Timer cooldownTimer;
	int ghostToSpawn = -1;

	
	void Start () {
		OnCooldownFinish(null, null);
		cooldownTimer = new System.Timers.Timer(9000d);
		cooldownTimer.Elapsed += new ElapsedEventHandler(OnCooldownFinish);
		cooldownTimer.AutoReset = true;
		cooldownTimer.Enabled = true;
	}

	void Update(){
		switch(ghostToSpawn)
		{
		case 0:
			GameObject obj1 = Instantiate(ghost0) as GameObject;
			break;
		case 1:
			GameObject obj2 = Instantiate(ghost1) as GameObject;
			break;
		case 2:
			GameObject obj3 = Instantiate(ghost2) as GameObject;
			break;
		case 3:
			GameObject obj4 = Instantiate(ghost3) as GameObject;
			break;
		default:
			break;
		}
		ghostToSpawn = -1;
	}
	
	void OnCooldownFinish(object source, ElapsedEventArgs e){
		ghostToSpawn = ghostNum % 4;
		ghostNum++;
	}
}
