using UnityEngine;
using System.Collections;

public class PickUpScript : MonoBehaviour {
	
	public void PickUp(string obj){
		if (obj == Items.POTION) {
			PickupData.potions ++;
		} else if (obj == Items.CARROT) {
			QuestItem(1);
			if(QuestData.quest >= 3){
				QuestData.questProgress = 100;
			}
		} else if (obj == Items.CORN) {
			QuestItem(2);
			if(QuestData.quest >= 3){
				QuestData.questProgress = 50;
			}
		} else if (obj == Items.SHELL) {
			QuestItem2(1);
			if(QuestData.quest == 5){
				QuestData.questProgress = 100;
			} else if(QuestData.quest == 6){
				QuestData.questProgress += 25;
			}
		} else if (obj == Items.CASKET) {
			QuestItem3(1);
			if(QuestData.quest == 6){
				QuestData.questProgress += 25;
			}
		} else if (obj == Items.ROPE) {
			QuestItem4(1);
			if(QuestData.quest == 6){
				QuestData.questProgress += 25;
			}
		}
	}

	void QuestItem(int item){
		if (QuestData.questItems[0] == 0) {
			QuestData.questItems[0] = item;
		} else {

		}
	}
	void QuestItem2(int item){
		if (QuestData.questItems[1] == 0) {
			QuestData.questItems[1] = item;
		} else {
			
		}
	}
	void QuestItem3(int item){
		if (QuestData.questItems[2] == 0) {
			QuestData.questItems[2] = item;
		} else {
			
		}
	}
	void QuestItem4(int item){
		if (QuestData.questItems[3] == 0) {
			QuestData.questItems[3] = item;
		} else {
			
		}
	}
}
