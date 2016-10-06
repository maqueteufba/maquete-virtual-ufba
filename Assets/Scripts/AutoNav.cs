using UnityEngine;
using System.Collections;

public class AutoNav: MonoBehaviour {
	
	private CharacterController controle;
	private SampleAgentScript script;
	private NavMeshAgent navmesh;
	//private Canvas autonavON;

	void Start () {
		controle = GetComponent<CharacterController> ();

		navmesh = GetComponent<NavMeshAgent> ();
		navmesh.enabled = false;
		script = GetComponent<SampleAgentScript> ();
		script.enabled = false;

		//autonavON = GetComponent<Canvas> ();
		//autonavON.enabled = false; 
	}

	void Update () {
		if (Input.GetKeyUp (KeyCode.I) || Input.GetMouseButtonDown(0)) {
			controle.enabled = !controle.enabled;
			script.enabled = !script.enabled;
			navmesh.enabled = !navmesh.enabled;

			//autonavON.enabled = !autonavON.enabled;
		}
	}

	public void GoTo(){

	}
}