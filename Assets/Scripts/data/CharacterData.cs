using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

//System.Serializable]
public class CharacterData : MonoBehaviour {
	private int _positionY;
	private int _positionX;
	//private int _exp;
	private int _health;
	private int _gold;
	private int _level;
	private int _quest;
	private int _questDone;
	private int _questProgress;
	private int _weapon;
	
	#region Getter and setters for Position + updating Position
		public int positionY{
			get {
				return _positionY;
			}
			set {
				_positionY = value;
			}
		}

		public int positionX{
			get {
				return _positionX;
			}
			set {
				_positionX = value;
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
	
	#region Getter and setters for questDone
	public int questDone{
		get{
			return _questDone;
		}
		set{
			_questDone = value;
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