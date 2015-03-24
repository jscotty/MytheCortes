using UnityEngine;
using System.Collections;

public class TempleEntrance : MonoBehaviour {
	public SaveLoadDataSerialized save;
	public int level;
	public GameObject bees;

	enum Item{Nothing = 0, Carrot = 1, Corn = 2};

	public void CheckRequirements(){
		int[] questItem = QuestData.questItems;

			CheckItems ((Item)questItem [0]);

	}

	void CheckItems(Item item){
		int quest = QuestData.quest;
		int questDone = QuestData.questDone;

		switch (item) {
		case Item.Nothing:
			if (questDone >= 3) {
				Load();
			} else {
				QuestData.questProgress = 50;
			}
			break;
		case Item.Carrot:
			if (questDone >= 3) {
				Load();
			} else {
				QuestData.questItems[0] = 0;
				Load();
			}
			break;
		case Item.Corn:
			bees.SetActive(true);
			QuestData.questItems[0] = 0;
			break;
		default:
			break;
		}
	}

	void Load(){
		LoadingScreen.isLoading = true;
		Application.LoadLevel(level);
			save.Save();

	}
}
