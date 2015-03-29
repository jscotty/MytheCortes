using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InventoryScript : MonoBehaviour {

	[SerializeField]
	private Text[] itemText;


	void Start(){

		itemText [0].text = "Potions: (" + PickupData.potions + ")";
	}

	public void StartInventory(){
		itemText [0].text = "Potions: (" + PickupData.potions + ")";
	}

	public void TakePotion(){
		if (PickupData.potions >= 1) {
			if(PlayerData.health >= 500){
				
			} else {
				PickupData.potions -= 1;
				PlayerData.health = 500;
				
				StartInventory();
			}
		} else {
			PickupData.potions = 0;
			StartInventory();
		}
	}
}
