using UnityEngine;
using System.Collections;

public class TrapDoor : MonoBehaviour {

	[SerializeField]
	private int _kills;
	[SerializeField]
	private GameObject door;

	void Update(){
		if(_kills <= 0){
			gameObject.SetActive(false);
			door.SetActive(true);
		}
	}

	#region get and set
	public int kills{
		get {
			return _kills;
		}
		set {
			_kills = value;
		}
	}
	#endregion
}
