using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {

	/// <summary>
	/// The panels 0 = Main Menu, 1 = Options Menu, 2 = Credits Menu.
	/// </summary>
	public GameObject[] panels;

	public void OnDown(string btn){

		if (btn == ButtonNames.START) {
			LoadingScreen.isLoading = true;
			Application.LoadLevel(1);
		} else if (btn == ButtonNames.HOW_TO_PLAY) {
			Credits();
		} else if (btn == ButtonNames.OPTIONS) {
			Options();
		} else if (btn == ButtonNames.FACEBOOK) {
			Application.OpenURL("https://www.facebook.com/QuestofCortez");
		} else if (btn == ButtonNames.BACK) {
			Back();
		}
	}

	void Options(){
		panels [0].SetActive (false);
		panels [1].SetActive (true);
		panels [2].SetActive (false);
	}
	void Credits(){
		panels [0].SetActive (false);
		panels [1].SetActive (false);
		panels [2].SetActive (true);
	}
	void Back(){
		panels [0].SetActive (true);
		panels [1].SetActive (false);
		panels [2].SetActive (false);
	}
}
