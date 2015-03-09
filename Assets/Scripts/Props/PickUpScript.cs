using UnityEngine;
using System.Collections;

public class PickUpScript : MonoBehaviour {

	private CharacterData playerData;

	void Start(){
		playerData = gameObject.GetComponent<CharacterData> ();
	}

	public void PickUp(string obj, int amount){
		if (obj == Items.POTION) {
			playerData.potions += amount;
			print("pickup potion");
		}
	}
}
