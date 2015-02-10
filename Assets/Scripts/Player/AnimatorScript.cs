using UnityEngine;
using System.Collections;

public class AnimatorScript : MonoBehaviour {

	Animator swordAnim;
	public bool attack;
	bool move;
	GameObject player;

	void Start(){
		swordAnim = GetComponent<Animator> ();
		player = GameObject.FindGameObjectWithTag ("Player");

	}

	void Update(){
		attack = player.GetComponent<PlayerController> ().attack;
		gameObject.GetComponent<AttackScript> ().attacking = attack;

		if (attack == true) {
			swordAnim.SetBool("Attack", true);
			move = false;
			player.GetComponent<PlayerController> ().move = move;
			//collider2D.isTrigger = true;
		}
	}

	public void StopAttack(){
		swordAnim.SetBool("Attack", false);	
		attack = false;
		move = true;
		gameObject.GetComponent<AttackScript> ().attacking = attack;
		GameObject enemys = GameObject.FindGameObjectWithTag ("Enemy");
		enemys.GetComponent<DummyBehaviour> ().damaging = false;
		//collider2D.isTrigger = false;

		player.GetComponent<PlayerController> ().attack = attack;
		player.GetComponent<PlayerController> ().move = move;
	}
}
