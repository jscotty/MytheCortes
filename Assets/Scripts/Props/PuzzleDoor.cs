using UnityEngine;
using System.Collections;

public class PuzzleDoor : MonoBehaviour {

	public TalkScript talk;
	public GameObject[] talkDoors;
	public GameObject[] door;


	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == Tags.PLAYER) {
			talk.StartTalk(Names.COLOR_DOOR);
			for (int i = 0; i < door.Length; i++) {
				door[i].SetActive(true);
				talkDoors[i].SetActive(false);
			}
		}
	}

	void OnTriggerExit2D(Collider2D other){

	}
}
