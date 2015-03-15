using UnityEngine;
using System.Collections;

public class SortingLayer : MonoBehaviour {

	void OnTriggerStay2D(Collider2D other){
		if (other.tag == Tags.FEET) {
			gameObject.GetComponent<Renderer>().sortingOrder = 10;
		}
		else if (other.tag == Tags.ENEMY_FEET) {
			gameObject.GetComponent<Renderer>().sortingOrder = 10;
		}
	}

	void OnTriggerExit2D(Collider2D other){
		gameObject.GetComponent<Renderer>().sortingOrder = -10;
	}
}
