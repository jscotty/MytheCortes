using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InventoryImages : MonoBehaviour {

	public Sprite[] sprites;
	public Image[] images;
	public GameObject[] imageObjects;

	enum QuestItems{Nothing, Carrot, Corn, Shell, Casket, Rope};

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
		switch (questItems[1]) {
			case 0:
			UpdateImages2 (QuestItems.Nothing);
			break;
			case 1:
			UpdateImages2 (QuestItems.Shell);
			break;
			default:
			
			break;
		}
		switch (questItems[2]) {
		case 0:
			UpdateImages3 (QuestItems.Nothing);
			break;
		case 1:
			UpdateImages3 (QuestItems.Casket);
			break;
		default:
			
			break;
		}
		switch (questItems[3]) {
		case 0:
			UpdateImages4 (QuestItems.Nothing);
			break;
		case 1:
			UpdateImages4 (QuestItems.Rope);
			break;
		default:
			
			break;
		}
	}

	void UpdateImages (QuestItems item){
		if (item == QuestItems.Nothing) {
			imageObjects [0].SetActive (false);
		} else if (item == QuestItems.Carrot) {
			imageObjects [0].SetActive (true);
			images [0].sprite = sprites [0];
		} else if (item == QuestItems.Corn) {
			imageObjects [0].SetActive (true);
			images [0].sprite = sprites [1];
		}
	}
	void UpdateImages2 (QuestItems item){
		if (item == QuestItems.Nothing) {
			imageObjects [1].SetActive (false);
		} else if (item == QuestItems.Shell) {
			imageObjects [1].SetActive (true);
			images [1].sprite = sprites [2];
		}
	}
	void UpdateImages3 (QuestItems item){
		if (item == QuestItems.Nothing) {
			imageObjects [2].SetActive (false);
		} else if (item == QuestItems.Casket) {
			imageObjects [2].SetActive (true);
			images [2].sprite = sprites [3];
		}
	}
	void UpdateImages4 (QuestItems item){
		if (item == QuestItems.Nothing) {
			imageObjects [3].SetActive (false);
		} else if (item == QuestItems.Rope) {
			imageObjects [3].SetActive (true);
			images [3].sprite = sprites [4];
		}
	}

}
