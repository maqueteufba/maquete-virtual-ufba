using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class UIManager : MonoBehaviour {

	GameObject[] pauseObjects;

	public GameObject fps;
	public GameObject fundo, botaoPlay;


	void Start () {
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");

		showCommom (false);
		hidePaused();
	}


	void Update () {

		if (Input.GetKeyUp (KeyCode.Escape)) {
			if (Time.timeScale == 1) {
				Time.timeScale = 0;
				fps.GetComponent<FirstPersonController> ().enabled = false;

				showCommom (true);
				showPaused ();
			}
			 else if (Time.timeScale == 0){
				//Debug.Log ("high");
				Time.timeScale = 1;
				fps.GetComponent<FirstPersonController> ().enabled = true;

				showCommom (false);
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
			fps.GetComponent<FirstPersonController> ().enabled = false;

			showCommom (true);
			showPaused();

		} else if (Time.timeScale == 0){
			Time.timeScale = 1;
			fps.GetComponent<FirstPersonController> ().enabled = true;

			showCommom (false);
			hidePaused();
		}
	}

	//shows objects with ShowOnPause tag
	public void showPaused(){

		foreach(GameObject g in pauseObjects){
			g.SetActive(true);
		}
	}

	//hides objects with ShowOnPause tag
	public void hidePaused(){			
		foreach(GameObject g in pauseObjects){
			g.SetActive(false);
		}
	}

	public void showCommom(bool active){
		fundo.SetActive (active);
		botaoPlay.SetActive (active);
	}

	//loads inputted level
	public void LoadLevel(string level){
		Application.LoadLevel(level);
	}

}
