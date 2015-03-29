using UnityEngine;
using System.Collections;

public class BeeAnimation : MonoBehaviour {

	public MoveToPlayer move;
	public EnemyData enemyData;

	private Animator _anim;
	private float _dirX,_dirY,_health;
	private bool _enemyAlive;
	private float _count;

	void Start(){
		_anim = gameObject.GetComponent<Animator> ();
	}

	void Update(){
		_dirX = move.dirX;
		_dirY = move.dirY;
		_health = enemyData.health;
		_enemyAlive = move.move;

		if (enemyData.died) {
			_anim.SetBool(AnimNames.DEATH,true);
			enemyData.damage = 0;
			_anim.SetBool(AnimNames.ATTACK, false);
		} else {
			if (_dirX == 0 && _dirY == 0 && _enemyAlive) {
				_anim.SetBool(AnimNames.ATTACK,true);
				_anim.SetBool(AnimNames.WALK, false);
			} else {
				_anim.SetBool(AnimNames.WALK, true);
				_anim.SetBool(AnimNames.ATTACK, false);
			}
		}
	}

	public void DamagePlayer(){
		PlayerData.health -= enemyData.damage;
	}
}
