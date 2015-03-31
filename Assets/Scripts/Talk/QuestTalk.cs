using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class QuestTalk : MonoBehaviour {
	public TempleEntrance temple;

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
	private int _quest, _questProgress;
	
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
		//QuestData.questDone = 1;
	}

	public void StartType(string NPC){
		_npc = NPC;
		
		if(_npc == Names.TEMPLE_DOOR){
			temple.CheckRequirements();
		} else if(_npc == Names.AZTEK_01){
			QuestData.questProgress = 100;
		}

		int questProgress = QuestData.questProgress;
		int quest = QuestData.quest;
		/*_quest = questData.quest;
		_questDone = questData.questDone;
		_questProgress = questData.questProgress;*/
		
		_playerController.move = false; 


		Dictionary<string, NpcTalkDictionary> npcTalk = new Dictionary<string, NpcTalkDictionary> ();
		
		NpcTalkDictionary player = new NpcTalkDictionary (Names.PLAYER, quest, questProgress, _story.PT_01, _story.PT_01, _story.PT_01, _story.PT_01, _story.PT_01,_story.PT_01);
		NpcTalkDictionary tutSoldier = new NpcTalkDictionary (Names.TUT_SOLDIER1, 1, questProgress, _story.TT1_01,_story.TT1_01,_story.TT1_01,_story.TT1_01,_story.TT1_02,_story.TT1_03);
		NpcTalkDictionary spaniard = new NpcTalkDictionary (Names.SPANIARD, quest, questProgress, _story.BT_01,_story.BT_01,_story.BT_01,_story.BT_01,_story.BT_01, _story.BT_01);
		NpcTalkDictionary spaniard2 = new NpcTalkDictionary (Names.SPANIARD2, quest, questProgress, _story.BT_02, _story.BT_02, _story.BT_02, _story.BT_02, _story.BT_02, _story.BT_02);
		NpcTalkDictionary spikes = new NpcTalkDictionary (Names.SPIKE_DEATH, quest, questProgress, _story.BT_SPIKES,_story.BT_SPIKES,_story.BT_SPIKES,_story.BT_SPIKES,_story.BT_SPIKES, _story.BT_SPIKES);
		NpcTalkDictionary malincheStart = new NpcTalkDictionary (Names.MALINCHE_START, 2, questProgress, _story.MT_01,_story.MT_01,_story.MT_01,_story.MT_01, _story.MT_01, _story.MT_01);
		NpcTalkDictionary templeDoor = new NpcTalkDictionary (Names.TEMPLE_DOOR, quest, questProgress, _story.BT_DOOR_01, _story.BT_DOOR_01, _story.BT_DOOR_01, _story.BT_DOOR_01, _story.BT_DOOR_03, _story.BT_DOOR_03);
		NpcTalkDictionary skull1 = new NpcTalkDictionary (Names.SKULLS, quest, questProgress, _story.BT_SKULLS, _story.BT_SKULLS, _story.BT_SKULLS, _story.BT_SKULLS, _story.BT_SKULLS, _story.BT_SKULLS);
		NpcTalkDictionary skull2 = new NpcTalkDictionary (Names.SKULLS2, quest, questProgress, _story.BT_SKULLS, _story.BT_SKULLS, _story.BT_SKULLS, _story.BT_SKULLS, _story.BT_SKULLS, _story.BT_SKULLS);
		NpcTalkDictionary aztek01 = new NpcTalkDictionary (Names.AZTEK_01, 4, questProgress, _story.TT_AZTEK_01, _story.TT_AZTEK_01, _story.TT_AZTEK_01, _story.TT_AZTEK_01, _story.TT_AZTEK_01, _story.TT_AZTEK_01);
		NpcTalkDictionary bees = new NpcTalkDictionary (Names.BEES, quest, questProgress, _story.BT_DOOR_02, _story.BT_DOOR_02, _story.BT_DOOR_02, _story.BT_DOOR_02, _story.BT_DOOR_02, _story.BT_DOOR_02);
		NpcTalkDictionary snailDoor = new NpcTalkDictionary (Names.SNAIL_DOOR, quest, questProgress, _story.TT_SNAIL_DOOR, _story.TT_SNAIL_DOOR, _story.TT_SNAIL_DOOR, _story.TT_SNAIL_DOOR, _story.TT_SNAIL_DOOR, _story.TT_SNAIL_DOOR);
		NpcTalkDictionary snails = new NpcTalkDictionary (Names.SNAIL, quest, questProgress, _story.TT_SNAILS, _story.TT_SNAILS, _story.TT_SNAILS, _story.TT_SNAILS, _story.TT_SNAILS, _story.TT_SNAILS);
		NpcTalkDictionary vase = new NpcTalkDictionary (Names.VASE, quest, questProgress, _story.TT_VASE, _story.TT_VASE, _story.TT_VASE, _story.TT_VASE, _story.TT_VASE, _story.TT_VASE);
		NpcTalkDictionary trap = new NpcTalkDictionary (Names.TRAP, quest, questProgress, _story.TT_TRAP, _story.TT_TRAP, _story.TT_TRAP, _story.TT_TRAP, _story.TT_TRAP, _story.TT_TRAP);
		NpcTalkDictionary thankfulAztek = new NpcTalkDictionary (Names.THANKFUL_AZTEK, quest, questProgress, _story.TT_THANKS, _story.TT_THANKS, _story.TT_THANKS, _story.TT_THANKS, _story.TT_THANKS, _story.TT_THANKS);
		NpcTalkDictionary end = new NpcTalkDictionary (Names.END, 6, questProgress, _story.TT_END, _story.TT_END, _story.TT_END, _story.TT_END, _story.TT_END, _story.TT_END);
		NpcTalkDictionary colorDoor = new NpcTalkDictionary (Names.COLOR_DOOR, quest, questProgress, _story.BT_COLOR_DOOR, _story.BT_COLOR_DOOR, _story.BT_COLOR_DOOR, _story.BT_COLOR_DOOR, _story.BT_COLOR_DOOR, _story.BT_COLOR_DOOR);

		npcTalk.Add (Names.PLAYER, player);
		npcTalk.Add (Names.TUT_SOLDIER1, tutSoldier);
		npcTalk.Add (Names.SPANIARD, spaniard);
		npcTalk.Add (Names.SPANIARD2, spaniard2);
		npcTalk.Add (Names.SPIKE_DEATH, spikes);
		npcTalk.Add (Names.MALINCHE_START, malincheStart);
		npcTalk.Add (Names.TEMPLE_DOOR, templeDoor);
		npcTalk.Add (Names.SKULLS, skull1);
		npcTalk.Add (Names.SKULLS2, skull2);
		npcTalk.Add (Names.AZTEK_01, aztek01);
		npcTalk.Add (Names.SNAIL_DOOR, snailDoor);
		npcTalk.Add (Names.SNAIL, snails);
		npcTalk.Add (Names.VASE, vase);
		npcTalk.Add (Names.TRAP, trap);
		npcTalk.Add (Names.THANKFUL_AZTEK, thankfulAztek);
		npcTalk.Add (Names.END, end);
		npcTalk.Add (Names.COLOR_DOOR, colorDoor);
		
		NpcTalkDictionary temp = null;
		if (npcTalk.TryGetValue (_npc, out temp)) {
			_autoType.Type(temp.SendString());
			_level = temp.level;
			_qId = temp.qId;
			_quest = temp.quest;
			_questProgress = temp.questProgress;
			if(_npc == Names.MALINCHE_START){
				QuestData.questProgress = 100;
			}
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
		if (_npc == Names.SPIKE_DEATH) {
			LoadingScreen.isLoading = true;
			Application.LoadLevel(4);	
		}
		if (_quest >= QuestData.questDone) {
			QuestData.quest = _quest;
			if (_questProgress == 100) {
				QuestData.questDone = _quest;	
				ResetPlayerQuestData();	
			}
		}

		if (_npc == Names.MALINCHE_START) {
			ResetPlayerQuestData();	
			QuestData.quest = 3;	
		}else if (_npc == Names.END) {
			LoadingScreen.isLoading = true;
			Application.LoadLevel(4);
		}

		_autoType.index = 0;
		talk.StopTalk ();
		joystick.interact = false;
		_playerController.move = true;
		//print ("Quests Done:" + QuestData._questDone);
		save.Save ();
	}

	
	public void ResetPlayerQuestData(){
		QuestData.quest ++;
		QuestData.questProgress = 0;
	}
}
