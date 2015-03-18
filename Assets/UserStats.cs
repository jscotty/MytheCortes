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
		int level = QuestData.level;

		statsText.text = 
			"Quests done: " + questDone + "\n" +
			"Doing quest: " + quest + "\n" +
			"Your Quest Progression: " + questProgress + "%" + "\n" +
			"Your in maplevel: " + level + "\n" +
			"npc kills: " + npcKills + "\n"  ;
	}
}
