using UnityEngine;
using System.Collections;

public class AnimatorScript : MonoBehaviour {

	Animator swordAnim;
	bool attack;
	bool move;
	GameObject player;

	void Start(){
		swordAnim = GetComponent<Animator> ();
		player = GameObject.FindGameObjectWithTag ("Player");

	}

	void Update(){
		attack = player.GetComponent<PlayerController> ().attack;
		move = player.GetComponent<PlayerController> ().move;

		if (attack == true) {
			swordAnim.SetBool("Attack", true);
			move = false;
			player.GetComponent<PlayerController> ().move = move;
		}
	}

	public void StopAttack(){
		swordAnim.SetBool("Attack", false);	
		attack = false;
		move = true;

		player.GetComponent<PlayerController> ().attack = attack;
		player.GetComponent<PlayerController> ().move = move;
	}
}
