using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class PasseiosManager : MonoBehaviour {
	public Animator animator;
	public UIManager uimanager;
	public GameObject fps;

	private GameObject[] botoesPasseios;

	void Start () {
		botoesPasseios = GameObject.FindGameObjectsWithTag("BotoesPasseios");

		hideBotoesPasseios ();
	}
	
	public void ChangeAnim(string anim){
		fps.GetComponent<FirstPersonController> ().enabled = false;

		hideBotoesPasseios ();

		uimanager.fundo.SetActive(false);
		Time.timeScale = 1;

		if (anim.Equals ("farmacia")) {
			animator.SetTrigger (anim);
		} else if (anim.Equals ("poli")) {
			uimanager.fundo.SetActive(false);
			animator.SetTrigger (anim);
		}
	}

	public void hideBotoesPasseios(){
		foreach(GameObject g in botoesPasseios){
			g.SetActive(false);
		}
	}

	public void showBotoesPasseios(){
		animator.enabled = true;
		foreach(GameObject g in botoesPasseios){
			g.SetActive(true);
		}
	}
}
