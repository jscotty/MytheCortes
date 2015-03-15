using UnityEngine;
using System.Collections;

public class QuestTalk : MonoBehaviour {

	private AutoType _autoType;
	private Story _story;
	private Joystick joystick;
	private SaveLoadDataSerialized save;
	private PlayerController _playerController;
	private TalkScript talk;
	private QuestData questData;
	private string _npc;
	private int _qId;
	private int _level;
	
	void Start(){
		_autoType = gameObject.GetComponent<AutoType> ();
		_story = gameObject.GetComponent<Story> ();
		
		GameObject saveData = GameObject.FindGameObjectWithTag (Tags.SAVE);
		save = saveData.GetComponent<SaveLoadDataSerialized> ();
		
		GameObject uiContr = GameObject.FindGameObjectWithTag (Tags.UI_CONTROLLER);
		talk = uiContr.GetComponent<TalkScript> ();
		
		GameObject joystick = GameObject.FindGameObjectWithTag (Tags.JOYSTICK_CONTROLLER);
		this.joystick = joystick.GetComponent<Joystick> ();
		
		GameObject player = GameObject.FindGameObjectWithTag (Tags.PLAYER);
		_playerController = player.GetComponent<PlayerController>();
	}

	public void StartType(string NPC){
		_npc = NPC;
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
			_autoType.Type(_story.PT_01);
			break;
		case Names.SPANIARD:
			_autoType.Type(_story.BT_01);
			break;
		case Names.ENEMY_BEACH:
			_autoType.Type(_story.BT_02);
			break;
		case Names.SKULLS:
			_autoType.Type(_story.BT_03);
			break;
		case Names.SKULLS2:
			_autoType.Type(_story.BT_03);
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
	
	public void Next(){
		_autoType.message = "";
		_autoType.index ++;
		StartType (_npc);
	}
	public void Skip(){
		_autoType.index = 900;
		_playerController.move = false;
		StartType (_npc);
	}
	
	
	public void EndType(){
		_autoType.index = 0;
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
	
	
	public void ResetPlayerQuestData(){
		QuestData.quest = 0;
		QuestData.questProgress = 0;
	}
	void Talk(int q){
		//save.Load ();
		if(QuestData.quest <= q && QuestData.questProgress < 100 && QuestData.questDone < 1){
			_autoType.Type(_story.TT1_01);
			QuestData.quest = q;
		} else if(QuestData.quest == q && QuestData.questProgress == 100){
			_autoType.Type(_story.TT1_02);
			QuestData.questDone ++;
			ResetPlayerQuestData();
		} else if(QuestData.questDone >= q){
			_autoType.Type(_story.TT1_03);
		}
		
		if (q == 90) {
			_autoType.Type(_story.BT_SPIKES);
			_level = 4;
		}
		_qId = q;
	}
}
