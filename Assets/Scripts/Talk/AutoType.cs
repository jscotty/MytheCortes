using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutoType : MonoBehaviour {

	SaveLoadDataSerialized save;
	public Text txt;
	string _message;
	float seconds = 0.01f;
	Story _story;
	string _npc;
	TalkScript talk;
	PlayerController _playerController;
	QuestData questData;

	Joystick joystick;
	private int _qId;
	private int _level;
	//int _quest, _questProgress, _questDone;

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
		_story = gameObject.GetComponent<Story> ();

		GameObject saveData = GameObject.FindGameObjectWithTag (Tags.SAVE);
		save = saveData.GetComponent<SaveLoadDataSerialized> ();

		GameObject uiContr = GameObject.FindGameObjectWithTag (Tags.UI_CONTROLLER);
		talk = uiContr.GetComponent<TalkScript> ();

		GameObject player = GameObject.FindGameObjectWithTag (Tags.PLAYER);
		_playerController = player.GetComponent<PlayerController>();

		GameObject joystick = GameObject.FindGameObjectWithTag (Tags.JOYSTICK_CONTROLLER);
		this.joystick = joystick.GetComponent<Joystick> ();

		questData = gameObject.GetComponent<QuestData> ();

		//StartType ("TS1");
	}

	public void StartType(string NPC){
		_npc = NPC;
		_i = index;
		/*_quest = questData.quest;
		_questDone = questData.questDone;
		_questProgress = questData.questProgress;*/

		_playerController.move = false;

		//print ("_quest (" + _quest + ") _questProgress(" + _questProgress + ") _questdone(" + _questDone + ")");

		switch (NPC) {
			case Names.TUT_SOLDIER1:
				Talk(1);
				break;
			case Names.PLAYER:
				Type(_story.PT_01);
				break;
			case Names.SPANIARD:
				Type(_story.BT_01);
				break;
			case Names.ENEMY_BEACH:
				Type(_story.BT_02);
				break;
			case Names.SKULLS:
				Type(_story.BT_03);
				break;
			case Names.SKULLS2:
				Type(_story.BT_03);
				break;
			case Names.SPIKE_DEATH:
				Talk(90);
				break;
			default:
				//nothing
				EndType();
				break;
				
		}
	}

	void Talk(int q){
		//save.Load ();
		if(QuestData.quest <= q && QuestData.questProgress < 100 && QuestData.questDone < 1){
			Type(_story.TT1_01);
			QuestData.quest = q;
		} else if(QuestData.quest == q && QuestData.questProgress == 100){
			Type(_story.TT1_02);
			QuestData.questDone ++;
			ResetPlayerQuestData();
		} else if(QuestData.questDone >= q){
			Type(_story.TT1_03);
		}

		if (q == 90) {
			Type(_story.BT_SPIKES);
			_level = 4;
		}
		_qId = q;
	}

	public void EndType(){
		index = 0;
		talk.StopTalk ();
		joystick.interact = false;
		_playerController.move = true;
		//print ("Quests Done:" + QuestData._questDone);
		save.Save ();
		if (_qId >= 90) {
			LoadingScreen.isLoading = true;
			Application.LoadLevel(_level);	
		}
	}

	public void Next(){
		_message = "";
		index ++;
		StartType (_npc);
	}
	public void Skip(){
		index = 900;
		_playerController.move = false;
		StartType (_npc);
	}

	public void ResetPlayerQuestData(){
		QuestData.quest = 0;
		QuestData.questProgress = 0;
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
