using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

	GameObject[] pauseObjects;
	private GameObject g;


	void Start () {
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
		g = GameObject.Find ("FPSController");

		hidePaused();
	}


	void Update () {

		//uses the p button to pause and unpause the game
		if (Input.GetKeyUp (KeyCode.Escape)) {
			if (Time.timeScale == 1) {
				Time.timeScale = 0;

				DisableMouseLook (true);

				showPaused ();
			}
			 else if (Time.timeScale == 0){
				Debug.Log ("high");
				Time.timeScale = 1;

				DisableMouseLook (false);

				hidePaused();
			}
		}
	}

	private void DisableMouseLook(bool enable){ 

		//g.GetComponent<Camera>().

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

	//loads inputted level
	public void LoadLevel(string level){
		Application.LoadLevel(level);
	}
		
}
