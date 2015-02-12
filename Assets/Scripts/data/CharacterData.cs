using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class CharacterData : MonoBehaviour {
	private Vector2 _position;
	private int _exp;
	private int _health;
	private int _gold;
	private int _level;
	private int _quest;
	private int _questProgress;
	private int _weapon;
	
	#region Getter and setters for Position + updating Position
		public Vector2 GetPosition(){
			return _position;
		}
		
		public void SetPosition(Vector2 position){
			_position = position;
		}
	#endregion

	#region Getter and setters for exp + updating exp
		public int GetExp(){
			return _exp;
		}
		
		public void SetExp(int amount){
			_exp = amount;
		}

		public void UpdateExp(int amount){
			_exp += amount;
		}
	#endregion
	
	#region Getter and setters for Health + updating Health
		public int GetHealth(){
			return _health;
		}
		
		public void SetHeath(int amount){
			_health = amount;
		}
		
		public void UpdateHealth(int amount){
			_health += amount;
		}
	#endregion
	
	#region Getter and setters for gold + updating Gold
		public int GetGold(){
			return _gold;
		}
		
		public void SetGold(int amount){
			_gold = amount;
		}
		
		public void UpdateGold(int amount){
			_gold += amount;
		}
	#endregion
	
	#region Getter and setters for Level + updating Level
	public int GetLevel(){
		return _level;
	}
	
	public void SetLevel(int amount){
		_level = amount;
	}
	
	public void UpdateLevel(int amount){
		_level += amount;
	}
	#endregion
	
	#region Getter and setters for Quest + updating Quest
	public int GetQuest(){
		return _quest;
	}
	
	public void SetQuest(int amount){
		_quest = amount;
	}
	
	public void UpdateQuest(int amount){
		_quest += amount;
	}
	#endregion
	
	#region Getter and setters for QuestProgress + updating QuestProgress
	public int GetQuestProgress(){
		return _questProgress;
	}
	
	public void SetQuestProgress(int amount){
		_questProgress = amount;
	}
	
	public void UpdateQuestProgress(int amount){
		_questProgress += amount;
	}
	#endregion

	#region Getter and setters for weapon + updating weapon
	public int GetWeapon(){
		return _weapon;
	}
	
	public void SetWeapon(int amount){
		_weapon = amount;
	}
	
	public void UpdateWeapon(int amount){
		_weapon += amount;
	}
	#endregion
}