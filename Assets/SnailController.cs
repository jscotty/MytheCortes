using UnityEngine;
using System.Collections;

public class SnailController : MonoBehaviour {

	public GameObject snail;

	public void Death(){
		snail.gameObject.tag = "Pickup";
	}
}
