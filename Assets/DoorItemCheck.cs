using UnityEngine;
using System.Collections;

public class DoorItemCheck : MonoBehaviour {
	public int itemRequired;
	public TalkScript talk;
	public GameObject door;

	enum Item{Nothing, Shell};

	void Update(){
		int questDone = QuestData.questDone;
		if (questDone >= 5) {
			gameObject.SetActive(false);
			door.SetActive(true);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == Tags.PLAYER) {
			CheckDoor();
		}
	}

	public void CheckDoor(){
		if (QuestData.questItems [1] == itemRequired) {
			OpenDoor(Item.Shell);		
		} else {
			OpenDoor(Item.Nothing);		
		}
	}

	void OpenDoor(Item item){
		switch (item) {
		case Item.Nothing:
			talk.StartTalk(Names.SNAIL_DOOR);
				break;
		case Item.Shell:
			door.SetActive(true);
			gameObject.SetActive(false);
			QuestComplete();
				break;
		default:
				break;
		}
	}

	void QuestComplete(){
		QuestData.questDone ++;
		QuestData.quest ++;
		QuestData.questProgress = 0;
	}
}
