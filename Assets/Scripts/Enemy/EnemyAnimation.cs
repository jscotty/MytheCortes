using UnityEngine;
using System.Collections;

public class EnemyAnimation : MonoBehaviour {
	public RandomWalking movement;

	private EnemyData _enemyData;
	private Animator _anim;

	void Start(){
		_enemyData = gameObject.GetComponent<EnemyData> ();
		_anim = gameObject.GetComponent<Animator> ();
	}

	void Update(){
		if (movement.dirX == 0 && movement.dirY == 0) {
			_anim.SetBool(AnimNames.WALK, false);
		} else {
			_anim.SetBool(AnimNames.WALK, true);
		}

		if (_enemyData.died) {
				
			_anim.SetBool(AnimNames.DEATH, true);
		}

	}
}
