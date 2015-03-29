using UnityEngine;
using System.Collections;

public class MalincheAnimation : MonoBehaviour {

	public MoveToPlayer move;
	private float _dirX, _dirY;
	private Animator anim;

	void Start(){
		anim = gameObject.GetComponent<Animator> ();
	}

	void Update(){
		_dirX = move.dirX;
		_dirY = move.dirY;
		if (_dirX == 0 && _dirY == 0){
			anim.SetBool(AnimNames.WALK, false);
		} else {
			anim.SetBool(AnimNames.WALK, true);
		}
	}
}
