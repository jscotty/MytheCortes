using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UserStats : MonoBehaviour {

	public Text statsText;
	public SaveLoadDataSerialized save;

	public static int npcKills;

	void Start(){
		LoadStats ();
	}

	public void LoadStats(){

		int questDone = QuestData.questDone;
		int quest = QuestData.quest;
		int questProgress = QuestData.questProgress;

		statsText.text = 
			"Doing quest: " + quest + "\n" +
			"Your Quest Progression: " + questProgress + "%" + "\n" +
			"Quests done: " + questDone + "\n" +
			"npc kills: " + npcKills + "\n"  ;
	}
}
