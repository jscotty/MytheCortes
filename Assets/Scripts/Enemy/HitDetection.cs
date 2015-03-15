using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class HitDetection : MonoBehaviour {

	bool _attack;

	DummyBehaviour _dummy;

	private bool _hit;

	void Start(){
		_dummy = gameObject.GetComponent<DummyBehaviour> ();
	}


	void OnTriggerStay2D(Collider2D other){
		if(other.tag == Tags.SWORD){
			//print("hit");
			_dummy.damaging = true;
		}
		//print ("hit: " + _hit);
	}
	
	void OnTriggerExit2D(Collider2D other){
		_dummy.damaging = false;
		//print ("hit: " + _hit);
	}
}
