using UnityEngine;
using System.Collections;

public class SortingLayer : MonoBehaviour {

	void OnTriggerStay2D(Collider2D other){
		if (other.tag == Tags.FEET) {
			gameObject.renderer.sortingOrder = 1;
		}
	}

	void OnTriggerExit2D(Collider2D other){
		gameObject.renderer.sortingOrder = 0;
	}
}
