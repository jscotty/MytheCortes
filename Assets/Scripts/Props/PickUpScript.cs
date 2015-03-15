using UnityEngine;
using System.Collections;

public class PickUpScript : MonoBehaviour {

	public void PickUp(string obj, int amount){
		if (obj == Items.POTION) {
			PickupData.potions += amount;
			print("pickup potion");
		}
	}
}
