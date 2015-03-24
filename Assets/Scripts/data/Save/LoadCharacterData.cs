using UnityEngine;
using System.Collections;

public class LoadCharacterData : MonoBehaviour {

	SaveLoadDataSerialized loadData;
	private int level;

	void Start(){
		loadData = gameObject.GetComponent<SaveLoadDataSerialized> ();
		loadData.Load ();
		//loadData.LoadChoosenCharacter ();

	}

	void Update(){
		if (loadData.loaded) {
			level = QuestData.level;
			LoadingScreen.isLoading = true;
			if(level <= 2){
				Application.LoadLevel(3);
			} else {
				Application.LoadLevel(level);
			}
		}
		Application.LoadLevel(3);
	}
}
