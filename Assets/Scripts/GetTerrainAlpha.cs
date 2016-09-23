using UnityEngine;
using System.Collections;

public class GetTerrainAlpha : MonoBehaviour {
	public Texture2D[] alphamapTextures;

	void Start () {
		//alphamapTextures = GetTerrainAlpha ();
	}
	
	void Update () {
		print ("textura "+ alphamapTextures);
	}
}
