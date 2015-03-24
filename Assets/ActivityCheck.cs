using UnityEngine;
using System.Collections;

public class ActivityCheck : MonoBehaviour {

	public int questDone;
	public bool active;

	void Update(){
		if (questDone <= QuestData.questDone) {
			gameObject.SetActive(false);		
		}

		if (active && questDone >= QuestData.questDone) {
			gameObject.SetActive(true);	
		}
	}
}
