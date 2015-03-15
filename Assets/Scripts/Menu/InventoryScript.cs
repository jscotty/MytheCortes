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
}
