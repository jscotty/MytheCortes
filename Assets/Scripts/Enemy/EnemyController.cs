using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	
	public AudioClip audioClip;
	[SerializeField]
	private float _damage;
	
	private AudioSource _audio;
	private EnemyData _enemyData;
	private RandomWalking _enemyMovement;
	private float _count;

	void Start(){
		_audio = gameObject.GetComponent<AudioSource> ();
		_enemyData = gameObject.GetComponent<EnemyData> ();
		_enemyMovement = gameObject.GetComponent<RandomWalking> ();
	}

	void Update(){
		if (_enemyData.health <= 0) {
			_enemyData.died = true;	
			_enemyMovement.move = false;
		}
		if (_enemyData.hit) {
			_count ++;
			if(_count == 1){
				_enemyData.health -= _damage;
				_audio.PlayOneShot(audioClip, 1f);
			}
		}
	}
}
