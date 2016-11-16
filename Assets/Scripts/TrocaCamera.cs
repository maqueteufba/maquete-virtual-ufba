using UnityEngine;
using System.Collections;

public class TrocaCamera : MonoBehaviour {
	public Camera cam1, cam2;

	// Use this for initialization
	void Start () {
		cam1.enabled = true;
		cam2.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.C)) {

			cam1.enabled = !cam1.enabled;

			/*//liga ou desliga o cursor
			if(cam1.enabled == false)
				Cursor.visible = true;
			else
				Cursor.visible = false;//*/

			cam2.enabled = !cam2.enabled;

		}
	}
}
