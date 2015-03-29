using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

	public EnemyData data;

	public void DamagePlayer(){
		PlayerData.health -= data.damage;
	}
}
