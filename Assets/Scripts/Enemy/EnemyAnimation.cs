using UnityEngine;
using System.Collections;

public class EnemyAnimation : MonoBehaviour {
	public RandomWalking movementRandom;
	public MoveToPlayer movementToPlayer;
	public bool crab;
	public EnemyData enemyData;

	private Animator _anim;
	private float _dirX, _dirY;
	private Vector2 _scale;
	private Vector2 _transformScale;

	void Start(){
		if (enemyData != null) {
				
		} else {
			enemyData = gameObject.GetComponent<EnemyData> ();
		} 
		_anim = gameObject.GetComponent<Animator> ();

		_transformScale = transform.localScale;
		_scale.y = _transformScale.y;
		_scale.x = _transformScale.x;
	}

	void Update(){
		if (movementRandom != null) {
			_dirX = movementRandom.dirX;
			_dirY = movementRandom.dirY;
		} else if(movementToPlayer != null){
			_dirX = movementToPlayer.dirX;
			_dirY = movementToPlayer.dirY;
		}
		if (_dirX == 0 && _dirY == 0) {
			_anim.SetBool(AnimNames.WALK, false);

			if(movementToPlayer != null){
				_anim.SetBool(AnimNames.ATTACK,true);
			}
		} else {
			_anim.SetBool(AnimNames.WALK, true);
			if(movementToPlayer != null){
				_anim.SetBool(AnimNames.ATTACK,false);
			}
		}

		if (enemyData.died) {
			_anim.SetBool(AnimNames.DEATH, true);
		}

		if (crab)
			ScaleCrab();

	}

	void ScaleCrab(){
		if (_dirX > 0) {
			_scale.x = -_transformScale.x;
		} else {
			_scale.x = _transformScale.x;
		}
		transform.localScale = _scale;
	}
}
