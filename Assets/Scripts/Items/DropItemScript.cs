using UnityEngine;
using System.Collections;

public class DropItemScript : MonoBehaviour {

	private CharacterData _playerData;
	private InventoryScript _inventory;

	void Start(){
		_playerData = new CharacterData ();

		_inventory = gameObject.GetComponent<InventoryScript> ();

	}

	public void Remove(string item){
		if (item == Items.POTION) {
			if(_playerData.potions >= 1){
				_playerData.potions --;
				_inventory.StartInventory();
			}
		} else if (item == Items.QUEST_ITEMS_1) {
			QuestData.questItems[0] = 0;
		} else if (item == Items.QUEST_ITEMS_2) {
			QuestData.questItems[1] = 0;
		} else if (item == Items.QUEST_ITEMS_3) {
			QuestData.questItems[2] = 0;
		} else if (item == Items.QUEST_ITEMS_4) {
			QuestData.questItems[3] = 0;
		}
	}
}
