using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fader : MonoBehaviour {
	Image _image;

	void Start(){
		_image = gameObject.GetComponent<Image> ();
		//FadeIn ();
	}


}
