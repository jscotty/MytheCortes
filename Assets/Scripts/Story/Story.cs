using UnityEngine;
using System.Collections;

public class Story : MonoBehaviour {

	/// <summary>
	/// TT stands for Tutorial Text.
	/// PT stands for Player Text
	/// </summary>

#region Tutorial story
	public readonly string[] TT1_01 = {
		"Soldier: Wel hello, i am prodregos the ultimatos",
		"Cortez: Heey man, i am your boss! and you need to teach me this game!",
		"Solider: Great! , Hit this DUMMY, and talk to me again!" 
	};

	public readonly string[] TT1_02 = {
		"Soldier: Weldone! you have learn how to fight ! Now leave the boat!"
	};

	public readonly string[] TT1_03 = {
		"Soldier: Please leave the boat."
	};
#endregion

	
#region BeachStorys
	public readonly string[] BT_01 = {
		"Soldier: Hey man, it is realy nice here!",
		"Cortez: Yeah , sexy"
	};
	
	public readonly string[] BT_02 = {
		"Aztek: brgllr ra gho reean do baboila",
		"Cortez: oke... ???"
	};

	public readonly string[] BT_03 = {
		"Cortez: Ew... I dont want to die like this..."
	};
	
	public readonly string[] BT_SPIKES = {
		"*Creapy sounds*",
		"Cortez: HEEY!?",
		"*Falling spikes*",
		"Cortez: NOOOOOOOOOOOOOOOOOOOOOHHHH!!!!"
	};
#endregion

#region PlayerMessages
	public readonly string[] PT_01 = {
		"I wonder why i can't go away.."
	};

#endregion

}
