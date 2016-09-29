using UnityEngine;
using System.Collections;

public class SwitchCameras : MonoBehaviour {

	Camera cam1, cam2;

	 void Start() {
	 	cam1 = GetComponent<Camera>();
		cam2 = GetComponent<Camera>();

		cam1.enabled = true;
    	cam2.enabled = false;
	 }

	 void Update() {
	     if (Input.GetKeyDown(KeyCode.C)) {
	         cam1.enabled = !cam1.enabled;
	         cam2.enabled = !cam2.enabled;
	     }
	 }
 }
