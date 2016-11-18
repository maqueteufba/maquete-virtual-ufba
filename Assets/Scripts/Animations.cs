using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour {

	public UIManager uiManager;

	void Start(){
		
	}
		
	public void SairAnim(){
		uiManager.TrocaCamera ();
		uiManager.sairAnimacao ();
	}
}
