using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InventoryImages : MonoBehaviour {

	public Sprite[] sprites;
	public Image[] images;
	public GameObject[] imageObjects;

	enum QuestItems{Nothing, Carrot, Corn};

	void Start(){
		UpdateInvImages ();
	}

	public void UpdateInvImages(){
		int[] questItems = QuestData.questItems;

		switch (questItems[0]) {
			case 0:
			UpdateImages (QuestItems.Nothing);
				break;
			case 1:
			UpdateImages (QuestItems.Carrot);
				break;
			case 2:
			UpdateImages (QuestItems.Corn);
				break;
			default:
						
				break;
		}
	}

	void UpdateImages (QuestItems item){
		if (item == QuestItems.Nothing) {
			imageObjects [0].SetActive (false);
			imageObjects [1].SetActive (false);
		} else if (item == QuestItems.Carrot) {
			imageObjects [0].SetActive (true);
			images [0].sprite = sprites [0];
		} else if (item == QuestItems.Corn) {
			imageObjects [0].SetActive (true);
			images [0].sprite = sprites [1];
		}
	}
}
