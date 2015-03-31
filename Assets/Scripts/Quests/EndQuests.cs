using UnityEngine;
using System.Collections;

public class EndQuests : MonoBehaviour {
	public TalkScript talk;
	
	public void Congratz(){
		talk.StartTalk (Names.END);
	}
}
