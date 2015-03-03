using UnityEngine;
using System.Collections;

public class FollowCharacter : MonoBehaviour {
	public Transform player;
	
	private Vector3 offset;
	
	void Start()
	{
		offset = transform.position - player.position; // calculate different bewtween camera and player
	}
	
	void Update()
	{
		transform.position = player.position + offset; // Camera keeps following the player
	}
}
