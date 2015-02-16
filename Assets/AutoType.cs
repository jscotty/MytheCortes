using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutoType : MonoBehaviour {
		
	public Text txt;
	string _message;
	float seconds = 0.03f;
	TutorialStory tutStory;
	string _npc;
	TalkScript talk;

	private int _i;
	public int index{
		get {
			return _i;
		}
		set {
			_i = value;
		}
	}

	void Start(){
		_i = 0;
		index = 0;
		tutStory = gameObject.GetComponent<TutorialStory> ();

		GameObject uiContr = GameObject.FindGameObjectWithTag (Tags.UI_CONTROLLER);
		talk = uiContr.GetComponent<TalkScript> ();
		//StartType ("TS1");
	}

	public void StartType(string NPC){
		_npc = NPC;
		_i = index;
		switch (NPC) {
			case Names.TUT_SOLDIER1:
				Type(tutStory.TT1);
				break;
			default:
				//nothing
				EndType();
				break;
				
		}
	}
	
	public void EndType(){
		index = 0;
		talk.StopTalk ();
	}

	public void Next(){
		index ++;
		StartType (_npc);
	}
	public void Skip(){
		index = 900;
		StartType (_npc);
	}

	void Type(string[] arg){
		txt.text = "";

		if (_i >= arg.Length) {
			EndType();	
		} else {
			_message = arg [_i];
			StartCoroutine (TypeText ());
		}
	}

	IEnumerator TypeText(){
		foreach (char letter in _message.ToCharArray()) {
			txt.text += letter;		

			yield return new WaitForSeconds(seconds);
		}
	}
}
