using UnityEngine;
using System.Collections;

public class LoadCharacterData : MonoBehaviour {

	SaveLoadDataSerialized loadData;
	private int level;
	private CharacterData playerData;

	void Start(){
		loadData = gameObject.GetComponent<SaveLoadDataSerialized> ();
		loadData.Load ();
		loadData.LoadChoosenCharacter ();

	}

	void Update(){
		if (loadData.loaded) {
			level = loadData.level;
			LoadingScreen.isLoading = true;
			if(level <= 2){
				Application.LoadLevel(3);
			} else {
				Application.LoadLevel(level);
			}
		}
	}
}
