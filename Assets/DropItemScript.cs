using UnityEngine;
using System.Collections;

public class DropItemScript : MonoBehaviour {

	private CharacterData _playerData;
	private InventoryScript _inventory;

	void Start(){
		GameObject player = GameObject.FindGameObjectWithTag (Tags.PLAYER);
		_playerData = player.GetComponent<CharacterData> ();

		_inventory = gameObject.GetComponent<InventoryScript> ();

	}

	public void Remove(string item){
		if (item == Items.POTION) {
			if(_playerData.potions >= 1){
				_playerData.potions --;
				_inventory.StartInventory();
			}
		}
	}
}
