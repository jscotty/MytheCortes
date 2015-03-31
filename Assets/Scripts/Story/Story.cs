using UnityEngine;
using System.Collections;

public class Story : MonoBehaviour {

	/// <summary>
	/// TT stands for Tutorial Text.
	/// PT stands for Player Text
	/// </summary>

#region Tutorial story
	public readonly string[] TT1_01 = {
		"Pedro:\nWell, haven’t seen you in a while. You’ve slept for such a long time",
		"Pedro:\nyou’ll probably be a bit rusty.",
		"Pedro:\n- Gives sword- ",
		"Pedro:\n“Use this sword to hit the training dummy over there.",
		"Pedro:\nit should wake your senses." 
	};

	public readonly string[] TT1_02 = {
		"Pedro:\nBeautiful strike! Elegant as always, captain!",
		"Pedro:\nThose savages will stand no chance against you!",
		"Pedro:\nNow off you go, get us some gold!"
	};

	public readonly string[] TT1_03 = {
		"Spaniard:\nPlease leave the boat."
	};
#endregion

	
#region BeachStorys
	public readonly string[] BT_01 = {
		"Juan:\nHey man, it is realy nice here!",
		"Cortez:\nYeah"
	};
	
	public readonly string[] BT_02 = {
		"Filippe:\nYou have to watch out.. it could be dangerous out here",
		"Cortez:\nokeman i'll watch out!"
	};

	public readonly string[] BT_SKULLS = {
		"Cortez:\nEw... I don't want to die like this...",
		"Malinche:\nHe was killed by a terrible trap.."
	};
	
	public readonly string[] BT_SPIKES = {
		"*Creepy sounds*",
		"Cortez:\nHEEY!?",
		"*Falling spikes*",
		"Cortez:\nNOOOOOOOOOOOOOOOOOOOOOHHHH!!!!"
	};

	public readonly string[] BT_DOOR_01 = {
		"Cortez:\nThere is something written on here?",
		"La\nMalinche: Let me see..",
		"Cortez:\nWhat does it mean?",
		"La Malinche:\nSomething about it being hungry. We should look for some food. What about that corn over there?"
	};
	
	public readonly string[] BT_DOOR_02 = {
		"-BZZZZZZZZZZSSZZZZ-"
	};

	public readonly string[] BT_DOOR_03 = {
		"-Door is opening-"
	};

	public readonly string[] BT_COLOR_DOOR = {
		"Cortez:\nLooks like troubl's up ahead.",
		"La Malinche:\nDepends on what you call trouble.",
		"La Malinche:\nSeems like you just have to pick a door.",
		"Cortez:\nBut wich one should i choose?"
	};

#endregion

#region TempleText

	public readonly string[] TT_AZTEK_01 = {
		"Aztek:\nSaying words you don't understand",
		"Cortez:\nWhat did he sayd?",
		"La Malinche:\nHe says we have to watch out for traps and agrassive azteks",
		"La Malinche:\nHe says also we have to go to the left"
	};
	public int[] heads_TT_AZTEK = {2,0,2,2};

	public readonly string[] TT_SNAIL_DOOR = {
		"Cortez:\nIt's locked!"
	};
	public readonly string[] TT_SNAILS = {
		"La Malinche:\nEww, gross!",
		"Cortez:\nCome on, they're just snailes"
	};
	public readonly string[] TT_VASE = {
		"La Malinche:\n*it looks big enough for something to fit in.*",
	};
	public readonly string[] TT_TRAP = {
		"*Doors shut*",
		"Cortez:\nOh shit.."
	};
	public readonly string[] TT_THANKS = {
		"Aztek:\n*Saying words you dont understand*",
		"La Malinche:\nHe thanks you for opening the door",
		"La Malinche:\nAnd he sayd that we are close to the gold."
	};
	public readonly string[] TT_END = {
		"Cortez:\nWe did it!",
		"La Malinche:\nYA! wow it is so beautifull!",
		"Cortez:\nYou are more beautifull...",
		"La Malinche:\nKiss me!",
		"*Kissing*"
	};
#endregion

#region Malinche text
	public readonly string[] MT_01 = {
		"La Malinche:\nGreetings, strange man with strange hairy face",
		"Cortez:\nYou… speak my language?",
		"La Malinche:\nSi, I learned a bit from a…. eh, whats the word? Traveller, a traveller who came here before you.",
		"Cortez:\nYou speak both our languages, it could be very helpful on my journey. Could I convince you to come with me in any way?",
		"La Malinche:\nI don’t know, I might need a little….. something to convince me?",
		"Cortez:\nI have many shiny things and magical shards of reflection, could this maybe change your mind?",
		"La Malinche:\nIt’s not much, but I’ll take it."
	};

#endregion

#region PlayerMessages
	public readonly string[] PT_01 = {
		"Cortez:\nI wonder why i can't go away.."
	};

#endregion

}
