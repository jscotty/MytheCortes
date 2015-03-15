using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InventoryScript : MonoBehaviour {

	[SerializeField]
	private Text[] itemText;


	void Start(){
		GameObject player = GameObject.FindGameObjectWithTag (Tags.PLAYER);

		itemText [0].text = "Potions: (" + PickupData.potions + ")";
	}

	public void StartInventory(){
		itemText [0].text = "Potions: (" + PickupData.potions + ")";
	}
}
