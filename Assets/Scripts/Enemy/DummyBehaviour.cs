using UnityEngine;
using System.Collections;

public class DummyBehaviour : MonoBehaviour {
	
	//public QuestData questData;
	public QuestState questState;
	public AudioClip audioClip;

	private bool _damaging;
	Animator _anim;
	private float _count;
	private AudioSource _audio;
	
	void Start(){
		_anim = gameObject.GetComponent<Animator> ();
		_audio = gameObject.GetComponent<AudioSource> ();

	}

	void Update(){
		if (_damaging) {
			_anim.SetBool("Hit", true);
			questState.EndQuest(1);
			_count ++;
			if(_count == 1f){
				if(QuestData.quest == 1){
					QuestData.questProgress = 100;
				}
				_audio.PlayOneShot(audioClip, 1f);
			}
		} else {
			_anim.SetBool("Hit", false);
			_count = 0f;
		}
	}

	#region getters and setters
	public bool damaging{
		get {
			return _damaging;
		}
		set {
			_damaging = value;
		}
	}
	#endregion
}
