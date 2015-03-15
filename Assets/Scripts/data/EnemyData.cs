using UnityEngine;
using System.Collections;

public class EnemyData : MonoBehaviour {

	[SerializeField]
	private float _health, _damage;
	
	private bool _died, _attack, _hit;
	
	#region Getters and Setters
	public float health {
		get {
			return _health;
		}
		set {
			_health = value;
		}
	}
	public float damage {
		get {
			return _damage;
		}
		set {
			_damage = value;
		}
	}
	public bool died {
		get {
			return _died;
		}
		set {
			_died = value;
		}
	}
	public bool attack {
		get {
			return _attack;
		}
		set {
			_attack = value;
		}
	}
	public bool hit {
		get {
			return _hit;
		}
		set {
			_hit = value;
		}
	}
	#endregion
}
