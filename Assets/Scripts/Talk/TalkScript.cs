using UnityEngine;
using System.Collections;

public class TalkScript : MonoBehaviour {

	public GameObject[] UI;
	QuestTalk _questTalk;

	void Start(){
		GameObject autoType = GameObject.FindGameObjectWithTag (Tags.TALK);
		_questTalk = autoType.GetComponent<QuestTalk> ();
	}

	public void StartTalk(string name){
		UI [0].SetActive (false);
		UI [1].SetActive (true);
		_questTalk.StartType (name);

	}
	
	public void StopTalk(){
		UI [0].SetActive (true);
		UI [1].SetActive (false);
	}
}
