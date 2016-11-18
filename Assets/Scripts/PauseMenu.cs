using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseMenu : MonoBehaviour {

	public GameObject fps;//para habilitar o controle do jogador
	public GameObject botoesPasseios, pauseComponents, primeiraTela; //conjunto de botoes
	public Camera fpscam, cinema; //trocar de cameras
	private Animator animator; //ativar a animacao da camera cinema

	private enum State {ANIM, PLAY};
	private State activeState;

	void Start () {
		fpscam.enabled = true;
		cinema.enabled = false;
		activeState = State.PLAY;

		animator = cinema.GetComponent<Animator> ();
		animator.enabled = false;

		botoesPasseios.SetActive(false);
		Pause ();
	}


	void Update () {

		if (Input.GetKeyUp (KeyCode.Escape)) {
			if (Time.timeScale == 1) {
				Pause ();
			}
			else if (Time.timeScale == 0)
				Resumir ();
			}
	}

	public void Pause(){
		Debug.Log (activeState.ToString());

		Time.timeScale = 0;
		fps.GetComponent<FirstPersonController> ().enabled = false;

		primeiraTela.SetActive (true);
		pauseComponents.SetActive (true);
	}

	public void Play(){	
		if (activeState == State.PLAY) {
			hideAll ();
			fps.GetComponent<FirstPersonController> ().enabled = true;
			Time.timeScale = 1;
		} else if (activeState == State.ANIM) {
			sairAnimacao ();
			Resumir ();
		}

		


	}

	public void Resumir(){
		if (activeState == State.PLAY)
			Play ();
		else if (activeState == State.ANIM)
			hideAll ();
		Time.timeScale = 1;

	}

	public void SegundaTela(){
		primeiraTela.SetActive(false);
		botoesPasseios.SetActive (true);
	}

	public void ChangeAnim(string anim){
		activeState = State.ANIM;
		animator.enabled = true; 

		if (anim.Equals ("farmacia")) {
			animator.SetTrigger (anim);

		} else if (anim.Equals ("poli")) {
			animator.SetTrigger (anim);
		}

		hideAll ();
		Time.timeScale = 1;
		TrocaCamera();
	}

	public void hideAll(){
		pauseComponents.SetActive (false);
		primeiraTela.SetActive (false);
		botoesPasseios.SetActive (false);
	}

	public void sairAnimacao(){
		//Debug.Log ("animacao finalizada");
		TrocaCamera();
		activeState = State.PLAY;

		animator.enabled = false;
		Pause ();
	}

	public void TrocaCamera(){
		fpscam.enabled = !fpscam.enabled;
		cinema.enabled = !cinema.enabled;
	}

	//Reloads the Level
	public void Reload(){
		Application.LoadLevel(Application.loadedLevel);
	}

	//loads inputted level
	public void LoadLevel(string level){
		Application.LoadLevel(level);
	}

}
