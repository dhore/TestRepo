using UnityEngine;
using System.Collections;

public class NavMesh : MonoBehaviour {

	NavMeshAgent navMeshAgent;
	public GameObject player;

	// Use this for initialization
	void Start () {
		navMeshAgent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		navMeshAgent.SetDestination(player.transform.position);
	}
}
