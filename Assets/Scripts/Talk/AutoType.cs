using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutoType : MonoBehaviour {

	public Text txt;

	private string _message;
	private string[] _catchedMessage;
	private float seconds = 0.01f;

	private QuestTalk _questTalk;
	//int _quest, _questProgress, _questDone;

	private int _i;

	void Start(){
		_i = 0;
		index = 0;

		_questTalk = gameObject.GetComponent<QuestTalk> ();

		//StartType ("TS1");
	}


	public void Type(string[] arg){
		txt.text = "";
		if (_i >= arg.Length) {
			_questTalk.EndType();	
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

	#region Getters and setters
	
	public int index{
		get {
			return _i;
		}
		set {
			_i = value;
		}
	}

	public string message {
		get {
			return _message;
		}
		set {
			_message = value;
		}
	}
	#endregion
}
