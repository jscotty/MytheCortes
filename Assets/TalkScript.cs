using UnityEngine;
using System.Collections;

public class TalkScript : MonoBehaviour {

	public GameObject[] UI;
	AutoType _autoType;

	void Start(){
		GameObject autoType = GameObject.FindGameObjectWithTag (Tags.TALK);
		_autoType = autoType.GetComponent<AutoType> ();
	}

	public void StartTalk(string name){
		UI [0].SetActive (false);
		UI [1].SetActive (true);

		_autoType.StartType (name);

	}
	
	public void StopTalk(){
		UI [0].SetActive (true);
		UI [1].SetActive (false);
	}
}
