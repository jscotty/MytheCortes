using UnityEngine;
using System.Collections;

public class Story : MonoBehaviour {

	/// <summary>
	/// TT stands for Tutorial Text.
	/// PT stands for Player Text
	/// </summary>

#region Tutorial story
	public readonly string[] TT1_01 = {
		"Spaniard:\nWel hello, i am prodregos the ultimatos",
		"Cortez:\nHeey man, i am your boss! and you need to teach me this game!",
		"Spaniard:\nGreat! , Hit this DUMMY, and talk to me again!" 
	};

	public readonly string[] TT1_02 = {
		"Spaniard:\nWeldone! you have learn how to fight ! Now leave the boat!"
	};

	public readonly string[] TT1_03 = {
		"Spaniard:\nPlease leave the boat."
	};
#endregion

	
#region BeachStorys
	public readonly string[] BT_01 = {
		"Soldier:\nHey man, it is realy nice here!",
		"Cortez:\nYeah , sexy"
	};
	
	public readonly string[] BT_02 = {
		"Soldier:\nYou have to watch out.. it could be dangerous out here",
		"Cortez:\nokeman i'll watch out!"
	};

	public readonly string[] BT_SKULLS = {
		"Cortez:\nEw... I don't want to die like this..."
	};
	
	public readonly string[] BT_SPIKES = {
		"*Creepy sounds*",
		"Cortez:\nHEEY!?",
		"*Falling spikes*",
		"Cortez:\nNOOOOOOOOOOOOOOOOOOOOOHHHH!!!!"
	};

	public readonly string[] BT_DOOR_01 = {
		"--** HANGRAOOYYY!! **--",
		"Cortez:\nI don't understand him..",
		"Malinche:\nHe says that he is hungry, grap some food and give it to him",
		"Cortez:\nOh okay thank you"
	};
	
	public readonly string[] BT_DOOR_02 = {
		"--** BAGRROAH DELL IOO!! **--",
		"Cortez:\nuuhh....",
		"Malinche:\nRun!! he will attack you",
		"Cortez:\nWhaha i kill these bastards!"
	};
#endregion

#region Malinche text
	public readonly string[] MT_01 = {
		"Malinche:\nheey hello, welcome in mid America",
		"Cortez:\nHello beautifull lady, my name is Cortez",
		"Malinche:\nI would like to help you in this adventure",
		"Cortez:\ncool sexy"
	};

#endregion

#region PlayerMessages
	public readonly string[] PT_01 = {
		"Cortez:\nI wonder why i can't go away.."
	};

#endregion

}
