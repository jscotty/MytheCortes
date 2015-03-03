using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {

	public void OnDown(string btn){

		if (btn == ButtonNames.START) {
			LoadingScreen.isLoading = true;
			Application.LoadLevel(1);
		} else if (btn == ButtonNames.HOW_TO_PLAY) {
			print("HowtoPlay");
		} else if (btn == ButtonNames.OPTIONS) {
			print("Options");
		} else if (btn == ButtonNames.FACEBOOK) {
			Application.OpenURL("https://www.facebook.com/QuestofCortez");
		}
	}
}
