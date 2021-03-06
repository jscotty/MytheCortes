﻿using UnityEngine;
using System.Collections;

[System.Serializable] 
public class CharacterData{
	private int _positionY;
	private int _positionX;
	private int _health;
	private int _gold;
	private int _level;
	private int _quest;
	private int _questDone;
	private int _questProgress;
	private int _weapon;
	private int _levelSpot;
	private int _potions;
	private int _npcKills;
	private int[] _questItems = new int[]{0,0,0,0};
	private bool _soundOn;
	
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

	#region getter and setter for Level spot
	public int levelSpot {
		get {
			return _levelSpot;
		}
		set {
			_levelSpot = value;
		}
	}
	#endregion
	
	#region getter and setter for potions
	public int potions {
		get {
			return _potions;
		}
		set {
			_potions = value;
		}
	}
	#endregion
	
	#region getter and setter for npcKills
	public int npcKills {
		get {
			return _npcKills;
		}
		set {
			_npcKills = value;
		}
	}
	#endregion
	
	#region getter and setter for questItems
	public int[] questItems {
		get {
			return _questItems;
		}
		set {
			_questItems = value;
		}
	}
	#endregion
	
	#region getter and setter for sound
	public bool soundOn {
		get {
			return _soundOn;
		}
		set {
			_soundOn = value;
		}
	}
	#endregion
}