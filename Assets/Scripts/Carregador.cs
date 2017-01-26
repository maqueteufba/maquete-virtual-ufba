using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carregador : MonoBehaviour {

	private GameObject objeto = null;
	public string URLDoBundle;
	public string NomeDoAsset;

	IEnumerator Download(){
		while (!Caching.ready)
			yield return null;
		using (WWW www = WWW.LoadFromCacheOrDownload (URLDoBundle, 0)) {
			yield return www;
			if (www.error != null)
				throw new UnityException ("O Download de " + NomeDoAsset + " falhou!\n" + www.error);
			AssetBundle bundle = www.assetBundle;
			if (NomeDoAsset == "")
				objeto = (GameObject)Instantiate (bundle.mainAsset);
			else
				objeto = (GameObject)Instantiate (bundle.LoadAsset(NomeDoAsset));
			bundle.Unload (false);
		}
	}

	void OnTriggerEnter(Collider outro){
		if ((outro.gameObject.tag == "Player") && (objeto == null)) {
			StartCoroutine (Download ());
			Debug.Log("baixo");
		}
	}

	void OnTriggerStay(Collider outro){
		if((objeto != null) && (outro.gameObject.tag == "Player")){
			objeto.SetActive(true);
			Debug.Log("ativo");
		}
	}

	void OnTriggerExit(Collider outro){
		if ((objeto != null) && (outro.gameObject.tag == "Player")) {
			objeto.SetActive(false);
			Debug.Log("desativo");
		}
	}
}
