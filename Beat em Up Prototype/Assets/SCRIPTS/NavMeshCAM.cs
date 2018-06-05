using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshCAM : MonoBehaviour {

	public Transform camTarget;
	public NavMeshAgent camAgent;
	
	void Update () {
		camAgent.destination = camTarget.position;
	}
}
