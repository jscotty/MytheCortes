using UnityEngine;
using System.Collections;

public class PlayerData : MonoBehaviour {

	public static int damage, health;

	[SerializeField]
	private int _damageValue;

	void Start(){
		if (health <= 0) {
			health = 500;	
		}

		damage = _damageValue;
	}
}
