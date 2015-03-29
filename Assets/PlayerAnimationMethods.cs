using UnityEngine;
using System.Collections;

public class PlayerAnimationMethods : MonoBehaviour {

	public PlayerController controller;

	public void StopFreezing(){
		controller.move = true;
	}
}
