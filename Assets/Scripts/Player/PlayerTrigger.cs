using UnityEngine;
using System.Collections;

public class PlayerTrigger : MonoBehaviour {
	InteractButtonText _btnText;
	SwordAnim _swordAnim;
	TalkScript _talkScript;
	Joystick _joystick;
	CharacterData _playerData;
	bool _talk;
	float _count;
	float _textIndex;

	void Start(){
		GameObject joysick = GameObject.FindGameObjectWithTag (Tags.JOYSTICK_CONTROLLER);
		_btnText = joysick.GetComponent<InteractButtonText> ();
		_joystick = joysick.GetComponent<Joystick> ();

		GameObject sword = GameObject.FindGameObjectWithTag (Tags.ATTACK);
		_swordAnim = sword.GetComponent<SwordAnim> ();

		GameObject ui = GameObject.FindGameObjectWithTag (Tags.UI_CONTROLLER);
		_talkScript = ui.GetComponent<TalkScript> ();

		_playerData = gameObject.GetComponent<CharacterData> ();
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.tag == Tags.NPC) {
			_btnText.message = "Talk";
			_swordAnim.talk = true;
			_talk = _joystick.GetInteract();
			if(_talk){
				_count ++;
				if(_count <= 1f) {
					_talkScript.StartTalk(other.name);
					_swordAnim.attack = false;
				}
			}
		}
	}

	void OnTriggerExit2D(Collider2D other){
		_btnText.message = "Attack";
		_swordAnim.talk = false;
		_count = 0f;
		_textIndex = 0;
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == Tags.TUTORIAL_DOOR) {
			if(_playerData.questDone >= 1){

			} else {
				_textIndex ++;
				if(_textIndex == 1){
					_talkScript.StartTalk(this.name);
				}
			}
		}
	}
}
