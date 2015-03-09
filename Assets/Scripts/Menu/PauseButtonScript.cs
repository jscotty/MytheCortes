using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseButtonScript : MonoBehaviour {
	SaveLoadDataSerialized _saveLoadData;

	public GameObject[] bannerButtons;
	public GameObject[] itemButtons;
	public GameObject[] panels;
	public Text text;


	private string[] txt = new string[]{"Inventory" ,"Saved succesfully", "Character", "Stats"};

	void Start(){
		GameObject saveData = GameObject.FindGameObjectWithTag (Tags.SAVE);
		_saveLoadData = saveData.GetComponent<SaveLoadDataSerialized> ();

		text.text = txt [0];
	}

	public void BackToMainMenu(){
		_saveLoadData.Save ();
		LoadingScreen.isLoading = true;
		Application.LoadLevel (0);
	}

	public void OpenInventory(){
		panels [0].SetActive (true);
		text.text = txt[0];
	}
	public void Save(){
		_saveLoadData.Save ();
		text.text = txt[1];
	}
	public void OpenCharacter(){
		panels [0].SetActive (false);
		text.text = txt[2];
	}
	public void OpenStats(){
		panels [0].SetActive (false);
		text.text = txt[3];
	}
}
