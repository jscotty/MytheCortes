using UnityEngine;
using System.Collections;

public class EnemyAnimation : MonoBehaviour {
	public RandomWalking movementRandom;
	public MoveToPlayer movementToPlayer;

	private EnemyData _enemyData;
	private Animator _anim;
	private float dirX, dirY;

	void Start(){
		_enemyData = gameObject.GetComponent<EnemyData> ();
		_anim = gameObject.GetComponent<Animator> ();
	}

	void Update(){
		if (movementRandom != null) {
			dirX = movementRandom.dirX;
			dirY = movementRandom.dirY;
		} else if(movementToPlayer != null){
			dirX = movementToPlayer.dirX;
			dirY = movementToPlayer.dirY;
		}
		if (dirX == 0 && dirY == 0) {
			_anim.SetBool(AnimNames.WALK, false);
		} else {
			_anim.SetBool(AnimNames.WALK, true);
		}

		if (_enemyData.died) {
			_anim.SetBool(AnimNames.DEATH, true);
		}

	}
}
