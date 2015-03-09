using UnityEngine;
using System.Collections;

public class PlayerTrigger : MonoBehaviour {
	InteractButtonText _btnText;
	SwordAnim _swordAnim;
	TalkScript _talkScript;
	Joystick _joystick;
	PickUpScript _pickup;
	bool _action;
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

		_pickup = gameObject.GetComponent<PickUpScript> ();

	}

	void OnTriggerStay2D(Collider2D other){
		_action = _joystick.GetInteract();
		if (other.tag == Tags.NPC) {
			_btnText.message = "Talk";
			_swordAnim.talk = true;
			if(_action){
				_count ++;
				if(_count <= 1f) {
					_talkScript.StartTalk(other.name);
					_swordAnim.attack = false;
				}
			}
		} else if (other.tag == Tags.PICKUP) {
			_btnText.message = "Take";
			_swordAnim.talk = true;
			if(_action){
				_count ++;
				if(_count <= 1f) {
					_pickup.PickUp(other.name, 1);
					other.gameObject.SetActive(false);
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
