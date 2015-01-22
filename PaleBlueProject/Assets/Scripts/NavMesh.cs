using UnityEngine;
using System.Collections;

public class NavMesh : MonoBehaviour {

	NavMeshAgent navMeshAgent;
	GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
		navMeshAgent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		navMeshAgent.SetDestination(player.transform.position);
	}
}
