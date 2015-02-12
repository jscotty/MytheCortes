using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class HitDetection : MonoBehaviour {

	public GameObject Player;
	public bool attacking;

	DummyBehaviour _dummy;
	GameObject _enemy;
	int _count;

	bool hit;

	void Start(){
		_count = -1;
		_enemy = GameObject.FindGameObjectWithTag ("Enemy");
	}

	void Update(){
		if (hit && attacking) {
			if(_dummy != null){
				_dummy.SetDamaging(true);
			}
		} else {
			if(_dummy != null){
				_dummy.SetDamaging(false);
			}
		}

	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Enemy"){
			_enemy = other.gameObject;
			_dummy = _enemy.GetComponent<DummyBehaviour>();

			hit = true;
		}else{
			hit = false;
		}
	}
}
