using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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
		
		
		Dictionary<string, NpcTalkDictionary> npcTalk = new Dictionary<string, NpcTalkDictionary> ();
		
		NpcTalkDictionary player = new NpcTalkDictionary (Names.PLAYER, 0, 0, _story.PT_01,null,null,null,null,_story.PT_01);
		NpcTalkDictionary tutSoldier = new NpcTalkDictionary (Names.TUT_SOLDIER1, 0, 0, _story.TT1_01,null,null,null,_story.TT1_02,_story.TT1_03);
		NpcTalkDictionary spaniard = new NpcTalkDictionary (Names.SPANIARD, 0, 0, _story.BT_01,null,null,null,null, _story.BT_01);
		NpcTalkDictionary spaniard2 = new NpcTalkDictionary (Names.SPANIARD2, 0, 0, _story.BT_02,null,null,null,null, _story.BT_02);
		
		npcTalk.Add (Names.SPANIARD, spaniard);
		npcTalk.Add (Names.SPANIARD2, spaniard2);
		
		NpcTalkDictionary temp = null;
		if (npcTalk.TryGetValue (_npc, out temp)) {
			_autoType.Type(temp.SendString());
		} else {
			EndType();
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
		if (_qId >= 90) {
			LoadingScreen.isLoading = true;
			Application.LoadLevel(_level);	
		}
		save.Save ();
	}
	
	
	public void ResetPlayerQuestData(){
		QuestData.quest = 0;
		QuestData.questProgress = 0;
	}

	void Quest(int q){
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
