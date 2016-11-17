using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class UIManager : MonoBehaviour {

	GameObject[] pauseObjects;

	public GameObject fps;
	public GameObject fundo;


	void Start () {
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");

		fundo.SetActive (false);
		hidePaused();
	}


	void Update () {

		if (Input.GetKeyUp (KeyCode.Escape)) {
			if (Time.timeScale == 1) {
				Time.timeScale = 0;

				fundo.SetActive (true);
				showPaused ();
			}
			 else if (Time.timeScale == 0){
				//Debug.Log ("high");
				Time.timeScale = 1;

				fundo.SetActive (false);
				hidePaused();
			}
		}
	}

	//Reloads the Level
	public void Reload(){
		Application.LoadLevel(Application.loadedLevel);
	}

	//controls the pausing of the scene
	public void pauseControl(){
		if(Time.timeScale == 1)
		{
			Time.timeScale = 0;
			showPaused();

		} else if (Time.timeScale == 0){
			Time.timeScale = 1;

			fundo.SetActive (false);
			hidePaused();
		}
	}

	//shows objects with ShowOnPause tag
	public void showPaused(){
		fps.GetComponent<FirstPersonController> ().enabled = false;

		foreach(GameObject g in pauseObjects){
			g.SetActive(true);
		}
	}

	//hides objects with ShowOnPause tag
	public void hidePaused(){
		fps.GetComponent<FirstPersonController> ().enabled = true;
			
		foreach(GameObject g in pauseObjects){
			g.SetActive(false);
		}
	}

	//loads inputted level
	public void LoadLevel(string level){
		Application.LoadLevel(level);
	}

}
