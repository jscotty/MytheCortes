using UnityEngine;
using System.Collections;
using System;

public class NpcTalkDictionary {
	
	private string _name;
	private int _progress;
	private int _quest;
	private int _level;
	private int _questId;
	private string[] _startText;
	private string[] _text25;
	private string[] _text50;
	private string[] _text75;
	private string[] _text100;
	private string[] _endText;

	public NpcTalkDictionary(string name, int quest, int progress, string[] text, string[] text2, string[] text3, string[] text4, string[] text5, string[] text6){
		this._name = name;
		this._progress = progress;
		this._quest = quest;
		this._startText = text;
		this._text25 = text2;
		this._text50 = text3;
		this._text75 = text4;
		this._text100 = text5;
		this._endText = text6;

	}

	public string[] SendString(){
		int q = QuestData.quest;
		int qDone = QuestData.questDone;
		int questProgress = QuestData.questProgress;
		Debug.Log (_quest + " progress: " + questProgress + " QuestDone: " + QuestData.questDone);

		if(q < _quest){
			QuestData.quest = _quest;
			return _startText;
		} else if(q == _quest && _progress <= 25 && qDone < _quest){
			return _text25;
		} else if(q == _quest && _progress <= 50 && qDone < _quest){
			return _text50;
		} else if(q == _quest && _progress <= 75 && qDone < _quest){
			return _text75;
		} else if(q == _quest && _progress == 100 && qDone < _quest){
			QuestData.questDone ++;
			ResetPlayerQuestData();
			return _text100;
		} else if(qDone >= q){
			return _endText;
		}
		
		if (q == 90) {
			_level = 4;
			return _startText;
		}
		_questId = q;
		return _startText;
	}
	
	public void ResetPlayerQuestData(){
		QuestData.quest = 0;
		QuestData.questProgress = 0;
	}

	#region Getters and Setters
	public int qId{
		get{
			return _level;
		}
	}
	public int level{
		get{
			return _level;
		}
	}
	#endregion

}
