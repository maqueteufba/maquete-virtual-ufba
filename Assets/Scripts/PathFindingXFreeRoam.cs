using UnityEngine;
using System.Collections;

public class PathFindingXFreeRoam : MonoBehaviour {
	
	private CharacterController controle;
	private SampleAgentScript script;
	private NavMeshAgent navmesh;

	void Start () {
		controle = GetComponent<CharacterController> ();

		navmesh = GetComponent<NavMeshAgent> ();
		navmesh.enabled = false;
		script = GetComponent<SampleAgentScript> ();
		script.enabled = false;
	}
	

	void Update () {
		if (Input.GetKeyUp (KeyCode.P)) {
			controle.enabled = !controle.enabled;
			script.enabled = !script.enabled;
			navmesh.enabled = !navmesh.enabled;
		}
	}
}