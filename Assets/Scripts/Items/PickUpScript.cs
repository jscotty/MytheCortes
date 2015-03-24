using UnityEngine;
using System.Collections;

public class PickUpScript : MonoBehaviour {
	
	public void PickUp(string obj, int amount){
		if (obj == Items.POTION) {
			PickupData.potions += amount;
		}
		if (obj == Items.CARROT) {
			QuestData.questItems[0] = 1;
			if(QuestData.quest >= 3){
				QuestData.questProgress = 100;
			}
		}
		if (obj == Items.CORN) {
			QuestData.questItems[0] = 2;
			if(QuestData.quest >= 3){
				QuestData.questProgress = 50;
			}
		}
	}
}
