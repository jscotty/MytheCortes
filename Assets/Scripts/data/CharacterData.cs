using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class CharacterData : MonoBehaviour {
	private Vector2 _position;
	//private int _exp;
	private int _health;
	private int _gold;
	private int _level;
	private int _quest;
	private int _questProgress;
	private int _weapon;
	
	#region Getter and setters for Position + updating Position
		public Vector2 position{
			get {
				return _position;
			}
			set {
				_position = value;
			}
		}
	#endregion

	/*#region Getter and setters for exp + updating exp
		public int GetExp(){
			return _exp;
		}
		
		public void SetExp(int amount){
			_exp = amount;
		}

		public void UpdateExp(int amount){
			_exp += amount;
		}
	#endregion*/
	
	#region Getter and setters for Health + updating Health
		public int health{
			get{
				return _health;
			}
			set{
				_health = value;
			}
		}
	#endregion
	
	#region Getter and setters for gold + updating Gold
	public int gold{
		get{
			return _gold;
		}
		set{
			_gold = value;
		}
	}
	#endregion
	
	#region Getter and setters for Level + updating Level
	public int level{
		get{
			return _level;
		}
		set{
			_level = value;
		}
	}
	#endregion
	
	#region Getter and setters for Quest + updating Quest
	public int quest{
		get{
			return _quest;
		}
		set{
			_quest = value;
		}
	}
	#endregion
	
	#region Getter and setters for QuestProgress + updating QuestProgress
	public int questProgress{
		get{
			return _questProgress;
		}
		set{
			_questProgress = value;
		}
	}
	#endregion

	#region Getter and setters for weapon + updating weapon
	public int weapon{
		get{
			return _weapon;
		}
		set{
			_weapon = value;
		}
	}
	#endregion
}