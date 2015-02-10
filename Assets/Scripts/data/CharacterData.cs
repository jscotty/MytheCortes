using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class CharacterData : MonoBehaviour {
	private int _exp;
	private int _health;
	private int _gold;
	private int _level;
	private int[] _items;
	private int[] _wearedItems;

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
	
	#region Getter and setters for Items + updating Items
	public int[] GetItems(){
		return _items;
	}
	
	public void SetItems(int[] amount){

	}
	
	public void UpdateItems(int amount){

	}
	#endregion
}
