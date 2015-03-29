using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	
	public AudioClip audioClip;
	public TrapDoor trapDoor;
	
	private AudioSource _audio;
	private EnemyData _enemyData;
	private RandomWalking _enemyMovement;
	private MoveToPlayer _moveToPlayer;
	private float _count;
	private float _killCount;

	void Start(){
		_audio = gameObject.GetComponent<AudioSource> ();
		_enemyData = gameObject.GetComponent<EnemyData> ();
		if (gameObject.GetComponent<RandomWalking> () != null) {
			_enemyMovement = gameObject.GetComponent<RandomWalking> ();
		} else {
			_moveToPlayer = gameObject.GetComponent<MoveToPlayer>();
		}
	}

	void Update(){
		if (_enemyData.health <= 0) {
			_enemyData.died = true;	

			if(_enemyMovement != null)
				_enemyMovement.move = false;
			else
				_moveToPlayer.move = false;

			_killCount ++;
			if(_killCount == 1f){
				UserStats.npcKills ++;
				if(trapDoor != null){
					trapDoor.kills --;
				}
			}
		}
		if (_enemyData.hit) {
			_count ++;
			if(_count == 1){
				_enemyData.health -= PlayerData.damage;
				_audio.PlayOneShot(audioClip, 1f);
			}
		} else {
			_count = 0;
		}

	}
}
