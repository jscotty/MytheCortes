using UnityEngine;
using System.Collections;

public class DoorItemCheck : MonoBehaviour {
	public int itemRequired;
	public TalkScript talk;
	public GameObject door;
	public bool ThreeItemsRequired;
	public bool snail;
	public bool trap;
	public int minQuestDone;

	private static int _count;

	enum Item{Nothing, Shell, MultiDoor};

	void Update(){
		int questDone = QuestData.questDone;
		if (questDone >= minQuestDone) {
			gameObject.SetActive(false);
			door.SetActive(true);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (ThreeItemsRequired) {
			if (other.tag == Tags.PLAYER) {
				CheckDoor2();
			}
		} else {
			if (other.tag == Tags.PLAYER) {
				if(snail){
					_count ++;
					if(_count == 1)
						talk.StartTalk(Names.SNAIL);
				}if(trap){
					_count ++;
					if(_count == 1)
						talk.StartTalk(Names.TRAP);
				} else {
					CheckDoor();
				}
			}
		}
	}

	public void CheckDoor(){
		if (QuestData.questItems [1] == itemRequired) {
			OpenDoor(Item.Shell);		
		} else {
			OpenDoor(Item.Nothing);		
		}
	}
	
	public void CheckDoor2(){
		if (QuestData.questItems [1] == itemRequired && QuestData.questItems[2] == itemRequired && QuestData.questItems[3] == itemRequired) {
			OpenDoor(Item.MultiDoor);		
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
			QuestData.questItems[1] = 0;
			break;
		case Item.MultiDoor:
			door.SetActive(true);
			gameObject.SetActive(false);
			QuestComplete();
			QuestData.questItems[1] = 0;
			QuestData.questItems[2] = 0;
			QuestData.questItems[3] = 0;
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
