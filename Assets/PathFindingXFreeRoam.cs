using UnityEngine;
using System.Collections;

public class PathFindingXFreeRoam : MonoBehaviour {
	
	private CharacterController controle;
	private NavMeshAgent script;

	void Start () {
		controle = GetComponent<CharacterController> ();
		script = GetComponent<NavMeshAgent> ();
	}
	

	void Update () {
		if (Input.GetKeyUp (KeyCode.P)) {
			controle.enabled = !controle.enabled;
			script.enabled = !script.enabled;
		}
	}
}