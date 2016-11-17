using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class PasseiosManager : MonoBehaviour {
	public Animator animator;
	public UIManager uimanager;
	public GameObject fps;

	private GameObject[] botoesPasseios;
	private Transform posicaoinicial;  

	void Start () {
		botoesPasseios = GameObject.FindGameObjectsWithTag("BotoesPasseios");

		hideBotoesPasseios ();

		posicaoinicial = fps.camera.transform;
	}
	
	public void ChangeAnim(string anim){
		fps.GetComponent<FirstPersonController> ().enabled = false;
		fps.transform.position = posicaoinicial.position;
		fps.transform.rotation = posicaoinicial.rotation;

		hideBotoesPasseios ();

		uimanager.showCommom (false);
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
		animator.enabled = true;
		foreach(GameObject g in botoesPasseios){
			g.SetActive(true);
		}
	}
}
