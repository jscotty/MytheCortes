using UnityEngine;
using System.Collections;

public class PlayerTrigger : MonoBehaviour {
	InteractButtonText _btnText;
	SwordAnim _swordAnim;
	TalkScript _talkScript;
	Joystick _joystick;
	bool _talk;
	float _count;
	bool _fade;

	void Start(){
		
		GameObject ui = GameObject.FindGameObjectWithTag (Tags.UI_CONTROLLER);
		if (ui != null)
			_talkScript = ui.GetComponent<TalkScript> ();

		GameObject joysick = GameObject.FindGameObjectWithTag (Tags.JOYSTICK_CONTROLLER);
		if (joysick != null) {
			_btnText = joysick.GetComponent<InteractButtonText> ();
			_joystick = joysick.GetComponent<Joystick> ();
		}

		GameObject sword = GameObject.FindGameObjectWithTag (Tags.ATTACK);
		_swordAnim = sword.GetComponent<SwordAnim> ();

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
	}
	
}
