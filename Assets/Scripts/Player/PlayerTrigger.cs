using UnityEngine;
using System.Collections;

public class PlayerTrigger : MonoBehaviour {
	public InteractHandler _interactHandler;

	InteractButtonText _btnText;
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


		_pickup = gameObject.GetComponent<PickUpScript> ();

	}

	void OnTriggerStay2D(Collider2D other){
		_action = _joystick.interact;
		if (other.tag == Tags.NPC) {
			_btnText.message = "Talk";
			_interactHandler.talk = true;
			if(_action){
				_count ++;
				if(_count <= 1f) {
					_talkScript.StartTalk(other.name);
					_interactHandler.attack = false;
					_interactHandler.talk = true;
				}
			}
			if(other.name == Names.SPIKE_DEATH){
				_count ++;
				if(_count <= 1f) {
					_talkScript.StartTalk(other.name);
					_interactHandler.attack = false;
					_interactHandler.talk = true;
				}
			}
		} else if (other.tag == Tags.PICKUP) {
			_btnText.message = "Take";
			_interactHandler.talk = true;
			if(_action){
				_count ++;
				if(_count <= 1f) {
					_pickup.PickUp(other.name, 1);
					other.gameObject.SetActive(false);
				}
			}
		}else{
		} 
	}

	void OnTriggerExit2D(Collider2D other){
		_btnText.message = "Attack";
		_interactHandler.talk = false;
		_count = 0f;
	}
	
}
