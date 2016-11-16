using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public Transform main, about;


	public void LoadScene(string name){
		Application.LoadLevel(name);
	}
	public void CHANGEPanels(bool toog){
		main.gameObject.SetActive(toog);
		about.gameObject.SetActive(!toog);
	}
}
