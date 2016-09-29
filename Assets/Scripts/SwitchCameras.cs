using UnityEngine;
using System.Collections;

public class SwitchCameras : MonoBehaviour {

	GameObject cam1, cam2;

	 void Start() {
		cam1 = GameObject.FindGameObjectWithTag("MainCamera");
		cam2 = GameObject.FindGameObjectWithTag("Cameras");

		cam1.SetActive(true);
		cam2.SetActive(false);
	 }

	 void Update() {
	     if (Input.GetKeyDown(KeyCode.C)) {
			cam1.SetActive(false);
			cam2.SetActive(true);
	     }
	 }
 }
