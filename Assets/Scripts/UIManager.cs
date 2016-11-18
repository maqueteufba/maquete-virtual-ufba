/*using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class UIManager : MonoBehaviour {

	public GameObject fps;
	public GameObject fundo, botaoPlay;
	public Camera fpscam, cinema;
	public Animator animator;

	public GameObject[] botoesPasseios, pauseObjects;
	private enum State {ANIM, PLAY, PAUSE};
	private State activeState;

	void Start () {
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
		botoesPasseios = GameObject.FindGameObjectsWithTag("BotoesPasseios");

		fpscam.enabled = true;
		cinema.enabled = false;
		Time.timeScale = 0;
		fps.GetComponent<FirstPersonController> ().enabled = false;

		hideBotoesPasseios();
		PauseLayoutVisible (true);
		showPaused ();

		activeState = State.PAUSE;
	}


	void Update () {

		if (Input.GetKeyUp (KeyCode.Escape)) {
			if (Time.timeScale == 1) {
				Time.timeScale = 0;
				fps.GetComponent<FirstPersonController> ().enabled = false;

				PauseLayoutVisible (true);
				showPaused ();

				activeState = State.PAUSE;
			}
			 else if (Time.timeScale == 0){
				Time.timeScale = 1;

				//if(activeState == State.PLAY)
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

			PauseLayoutVisible (true);
			showPaused();

		} else if (Time.timeScale == 0){
			Time.timeScale = 1;

			//if(State.PLAY || State.PAUSE)
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

	public void PauseLayoutVisible(bool visible){
		fundo.SetActive (visible);
		botaoPlay.SetActive (visible);
	}

	public void hideAll(){
		hidePaused ();
		PauseLayoutVisible (false);
		hideBotoesPasseios();
	}

	//loads inputted level
	public void LoadLevel(string level){
		Application.LoadLevel(level);
	}

	public void ChangeAnim(string anim){
		fps.GetComponent<FirstPersonController> ().enabled = false;
		hideBotoesPasseios ();
		PauseLayoutVisible (false);

		Time.timeScale = 1;
		TrocaCamera();

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
		//ATIVA BOTOES DE PASSEIOS DISPONIVEIS
		foreach(GameObject g in botoesPasseios){
			g.SetActive(true);
		}
	}

	public void sairAnimacao(){
		//Debug.Log ("animacao finalizada");
		TrocaCamera();

		animator.enabled = false;

		pauseControl ();
	}

	public void TrocaCamera(){
		fpscam.enabled = !fpscam.enabled;
		cinema.enabled = !cinema.enabled;
	}
}
*/