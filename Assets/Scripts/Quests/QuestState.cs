using UnityEngine;
using System.Collections;

public class QuestState : MonoBehaviour {

	private SaveLoadDataSerialized _save;

	void Start(){
		GameObject saveData = GameObject.FindGameObjectWithTag (Tags.SAVE);
		_save = saveData.GetComponent<SaveLoadDataSerialized> ();
	}
	
	public void UpdateQuestProgression(int quest, int value){
		if(QuestData.quest == quest){
			QuestData.questProgress = value;
			_save.Save();
		}
	}

	public void EndQuest(int quest){
		if(QuestData.quest == quest && QuestData.questProgress < 100){
			QuestData.questProgress = 100;
			_save.Save();
		}
	}
}
