using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InteractButtonText : MonoBehaviour {

	public Text txt;
	private string _msg = "attack";

	void Start(){
		txt.text = _msg;
	}

	#region setters for the message
	public string message {
		set {
			_msg = value;
			txt.text = _msg;
		}
	}
	#endregion

}
