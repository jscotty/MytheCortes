using UnityEngine;
using System.Collections;

public class PickUpScript : MonoBehaviour {
	
	public void PickUp(string obj, int amount){
		if (obj == Items.POTION) {
			PickupData.potions += amount;
		}
		if (obj == Items.CARROT) {
			QuestData.questItems[0] = 1;
			print("pickup Carrot");
		}
	}
}
