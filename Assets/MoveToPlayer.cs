using UnityEngine;
using System.Collections;

public class MoveToPlayer : MonoBehaviour {

	public Transform player;

	private float _dirX, _dirY;
	private Vector2 playerPosition;
	private Vector2 position;

	void Update(){
		playerPosition = player.transform.position;
	}
	
	#region Getters and Setters
	public float dirX {
		get{
			return _dirX;
		}
		set{
			_dirX = value;
		}
	}

	public float dirY {
		get{
			return _dirY;
		}
		set{
			_dirY = value;
		}
	}
	#endregion
}
