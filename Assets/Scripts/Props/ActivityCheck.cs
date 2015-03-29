using UnityEngine;
using System.Collections;

public class ActivityCheck : MonoBehaviour {

	public int questDone;
	public int minQuestDone;
	public bool active;

	void Start(){
		if (questDone == 0) {
			questDone = 900;	
		}
	}

	void Update(){
		
		if (minQuestDone > QuestData.questDone) {
			gameObject.SetActive(false);		
		} else if (minQuestDone <= QuestData.questDone) {
			gameObject.SetActive(true);	
		}

		if (questDone <= QuestData.questDone) {
			gameObject.SetActive(false);		
		} else if (active && questDone >= QuestData.questDone) {
			gameObject.SetActive(true);	
		}
	}
}
