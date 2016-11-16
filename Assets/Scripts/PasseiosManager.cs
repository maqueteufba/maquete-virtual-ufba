using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class PasseiosManager : MonoBehaviour {
	public Animator animator;
	//public enum Anim {idle, FARM, POLI};
	public GameObject fps;

	//private Anim passeioativo;

	void Start () {
		//passeioativo = Anim.idle;
	}
	
	public void ChangeAnim(string anim){
		if (anim.Equals("idle"))
			animator.SetTrigger (anim);
		
		else if (anim.Equals("farmacia")) {
			//Debug.Log ("tryingg");
			fps.GetComponent<FirstPersonController> ().enabled = false;

			animator.SetTrigger (anim);
		}
	}
}
