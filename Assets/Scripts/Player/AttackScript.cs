using UnityEngine;
using System.Collections;

public class AttackScript : MonoBehaviour {

	public GameObject Player;
	public bool attacking;

	GameObject enemy;

	bool hit;

	void Start(){
		enemy = GameObject.FindGameObjectWithTag ("Enemy");
	}

	void Update(){
		if (hit && attacking) {
			enemy.GetComponent<DummyBehaviour>().damaging = true;
		} else {
			enemy.GetComponent<DummyBehaviour>().damaging = false;
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Enemy"){
			enemy = other.gameObject;
			hit = true;
		}else{
			hit = false;
		}
	}
}
