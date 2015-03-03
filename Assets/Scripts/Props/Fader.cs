using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fader : MonoBehaviour {

	void Start(){
		gameObject.GetComponent<FadeMaterials> ().FadeOut ();
	}

	public void FadeIn(){
		gameObject.GetComponent<FadeMaterials> ().FadeIn ();
	}


}
