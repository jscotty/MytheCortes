using UnityEngine;
using System.Collections;

public class MoveButtonScript : MonoBehaviour {

	public float x,y;

	GameObject player;

	PlayerController playerController;

	void Start (){
		player = GameObject.FindGameObjectWithTag ("Player");
		playerController = player.GetComponent<PlayerController> ();
	}


	public void onDown(string direction){
		if (direction == "RIGHT") {
			playerController.x = 1f;
			playerController.y = 0f;
		} else if (direction == "LEFT") {
			playerController.x = -1f;
			playerController.y = 0;
		} else if (direction == "UP") {
			playerController.x = 0;
			playerController.y = 1f;
		} else if (direction == "DOWN") {
			playerController.x = 0;
			playerController.y = -1f;
		}
	}

	public void onUP(){
		playerController.x = 0f;
		playerController.y = 0f;
	}
}
