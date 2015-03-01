﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutoType : MonoBehaviour {
		
	public Text txt;
	string _message;
	float seconds = 0.01f;
	Story tutStory;
	string _npc;
	TalkScript talk;
	CharacterData _playerData;
	PlayerController _playerController;
	int _quest, _questProgress, _questDone;
	Joystick joystick;

	private int _i;
	public int index{
		get {
			return _i;
		}
		set {
			_i = value;
		}
	}

	void Start(){
		_i = 0;
		index = 0;
		tutStory = gameObject.GetComponent<Story> ();

		GameObject uiContr = GameObject.FindGameObjectWithTag (Tags.UI_CONTROLLER);
		talk = uiContr.GetComponent<TalkScript> ();

		GameObject player = GameObject.FindGameObjectWithTag (Tags.PLAYER);
		_playerData = player.GetComponent<CharacterData> ();
		_playerController = player.GetComponent<PlayerController>();

		GameObject joystick = GameObject.FindGameObjectWithTag (Tags.JOYSTICK_CONTROLLER);
		this.joystick = joystick.GetComponent<Joystick> ();

		//StartType ("TS1");
	}

	public void StartType(string NPC){
		_npc = NPC;
		_i = index;

		_quest = _playerData.quest;
		_questProgress = _playerData.questProgress;
		_questDone = _playerData.questDone;
		_playerController.SetMove (false);

		//print ("_quest (" + _quest + ") _questProgress(" + _questProgress + ") _questdone(" + _questDone + ")");

		switch (NPC) {
			case Names.TUT_SOLDIER1:
				Talk(1);
				break;
			case Names.PLAYER:
				Type(tutStory.PT_01);
				break;
			default:
				//nothing
				EndType();
				break;
				
		}
	}

	void Talk(int q){
		if(_quest <= q && _questProgress < 100 && _questDone < 1){
			Type(tutStory.TT1_01);
			_playerData.quest = q;
		} else if(_quest == q && _questProgress == 100){
			Type(tutStory.TT1_02);
			_playerData.questDone ++;
			ResetPlayerQuestData();
		} else if(_questDone >= q){
			Type(tutStory.TT1_03);
		}
	}

	public void EndType(){
		index = 0;
		talk.StopTalk ();
		joystick.SetInteract (false);
		_playerController.SetMove (true);
	}

	public void Next(){
		_message = "";
		index ++;
		StartType (_npc);
	}
	public void Skip(){
		index = 900;
		_playerController.SetMove (false);
		StartType (_npc);
	}

	public void ResetPlayerQuestData(){
		_playerData.quest = 0;
		_playerData.questProgress = 0;
	}

	void Type(string[] arg){
		txt.text = "";

		if (_i >= arg.Length) {
			EndType();	
		} else {
			_message = arg [_i];
			StartCoroutine (TypeText ());
		}
	}

	IEnumerator TypeText(){
		foreach (char letter in _message.ToCharArray()) {
			txt.text += letter;		

			yield return new WaitForSeconds(seconds);
		}
	}
}