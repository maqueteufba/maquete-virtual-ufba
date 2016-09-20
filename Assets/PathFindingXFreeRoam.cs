using UnityEngine;
using System.Collections;

public class PathFindingXFreeRoam : MonoBehaviour {
	CharacterController contro = new CharacterController();
	NavMesh nav = new NavMesh();
	SampleAgentScript script = new SampleAgentScript();
	GameObject s = new GameObject ();
	bool ativado = false;
	void Start () {
	
	}
	

	void Update () {
		if(Event.current.keyCode == KeyCode.P){
			
			//a.SetActive (true);
		//	b.SetActive (false);
			if (ativado == true) {
				ativado = false;
			} else {
				ativado = true;
			}
	}

}
}