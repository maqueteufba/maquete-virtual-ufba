using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class UIManager : MonoBehaviour {

	public GameObject fps;
	public GameObject fundo, botaoPlay;

	public Animator animator;

	private GameObject[] botoesPasseios;
	GameObject[] pauseObjects;

	void Start () {
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
		botoesPasseios = GameObject.FindGameObjectsWithTag("BotoesPasseios");

		Time.timeScale = 0;
		fps.GetComponent<FirstPersonController> ().enabled = false;

		hideBotoesPasseios ();
		showCommom (true);
		showPaused ();
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
				Time.timeScale = 1;
				fps.GetComponent<FirstPersonController> ().enabled = true;

				hideAll();
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

			hideAll();
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

	public void hideAll(){
		hidePaused ();
		showCommom (false);
		hideBotoesPasseios();
	}

	//loads inputted level
	public void LoadLevel(string level){
		Application.LoadLevel(level);
	}

	public void ChangeAnim(string anim){
		fps.GetComponent<FirstPersonController> ().enabled = false;

		hideBotoesPasseios ();

		showCommom (false);
		Time.timeScale = 1;

		if (anim.Equals ("farmacia")) {
			animator.SetTrigger (anim);

		} else if (anim.Equals ("poli")) {
			animator.SetTrigger (anim);
		}
	}

	public void hideBotoesPasseios(){
		foreach(GameObject g in botoesPasseios){
			g.SetActive(false);
		}
	}

	public void showBotoesPasseios(){
		//ATIVA COMPONENTE ANIMATOR!!!!!!!!!!
		animator.enabled = true;
		foreach(GameObject g in botoesPasseios){
			g.SetActive(true);
		}
	}

	public void sairAnimacao(){
		//Debug.Log ("animacao finalizada");
		animator.enabled = false;
		pauseControl ();
	}

}
