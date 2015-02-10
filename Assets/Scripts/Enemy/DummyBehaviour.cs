using UnityEngine;
using System.Collections;

public class DummyBehaviour : MonoBehaviour {

	public bool damaging;

	void Update(){
		if (damaging) {
			GetComponent<SpriteRenderer>().color = Color.yellow;
		} else {
			GetComponent<SpriteRenderer>().color = Color.red;
		}
	}
}
