using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InventoryScript : MonoBehaviour {

	[SerializeField]
	private Text[] itemText;

	private CharacterData _playerData;

	void Start(){
		GameObject player = GameObject.FindGameObjectWithTag (Tags.PLAYER);
		_playerData = player.GetComponent<CharacterData> ();

		itemText [0].text = "Potions: (" + _playerData.potions + ")";
	}

	public void StartInventory(){
		itemText [0].text = "Potions: (" + _playerData.potions + ")";
	}
}
