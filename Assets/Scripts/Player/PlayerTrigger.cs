using UnityEngine;
using System.Collections;

public class PlayerTrigger : MonoBehaviour {
	InteractButtonText btnText;
	SwordAnim swordAnim;
	TalkScript talkScript;
	Joystick joystick;
	bool talk;
	float _count;

	void Start(){
		GameObject joysick = GameObject.FindGameObjectWithTag (Tags.JOYSTICK_CONTROLLER);
		btnText = joysick.GetComponent<InteractButtonText> ();
		this.joystick = joysick.GetComponent<Joystick> ();

		GameObject sword = GameObject.FindGameObjectWithTag (Tags.ATTACK);
		swordAnim = sword.GetComponent<SwordAnim> ();

		GameObject ui = GameObject.FindGameObjectWithTag (Tags.UI_CONTROLLER);
		talkScript = ui.GetComponent<TalkScript> ();
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.tag == Tags.NPC) {
			btnText.message = "Talk";
			swordAnim.talk = true;
			talk = joystick.GetInteract();
			if(talk){
				_count ++;
				if(_count <= 1f) {
					talkScript.StartTalk(other.name);
					swordAnim.attack = false;
				}
			}
		}
	}
	void OnTriggerExit2D(Collider2D other){
		btnText.message = "Attack";
		swordAnim.talk = false;
		_count = 0f;
	}
}
