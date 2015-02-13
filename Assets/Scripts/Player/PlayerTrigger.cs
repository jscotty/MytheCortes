using UnityEngine;
using System.Collections;

public class PlayerTrigger : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == Tags.NPC) {
			print("talk");	
		}
	}
}
