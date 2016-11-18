using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour {

	public UIManager uiManager;
	public Transform posicao;

	private Transform posicaoinicial;

	void Start(){
		posicaoinicial = posicao;
		Debug.Log ("posicaoINICIAL: " + posicaoinicial.position.ToString ()+"rotacaoINICIAL: " +transform.rotation.ToString());
	}

	public void ResetPos(){
		posicao.position = new Vector3 (476.0f, 14.4f, 1276.0f);
		posicao.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 1.0f);
		//Debug.Log ("/////////////"+"posicaoINICIAL: " + posicaoinicial.position.ToString ()+"rotacaoINICIAL: " +transform.rotation.ToString());
		Debug.Log ("posicao fps: " + posicao.position.ToString ()+"rotacao camera: "+transform.rotation.ToString());
	}

	public void SairAnim(){
		//ResetPos ();
		uiManager.sairAnimacao ();
	}
}
