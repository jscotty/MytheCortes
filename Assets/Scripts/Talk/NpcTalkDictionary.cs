using UnityEngine;
using System.Collections;
using System;

public class NpcTalkDictionary {
	
	public string name;
	public int progress;
	public int quest;
	public string[] text;
	public string[] text2;
	public string[] text3;
	public string[] text4;

	public NpcTalkDictionary(string name, int progress, int quest, string[] text, string[] text2, string[] text3, string[] text4){
		this.name = name;
		this.progress = progress;
		this.quest = quest;
		this.text = text;
		this.text2 = text2;
		this.text3 = text3;
		this.text4 = text4;
	}

	public string[] SendString(){
		int q = QuestData.quest;
		if (q == QuestData) {
				
		} else if(q > QuestData){
			return text;
		} else {
			return text;
		}
	}

}
