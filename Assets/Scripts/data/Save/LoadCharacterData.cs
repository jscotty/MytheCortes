using UnityEngine;
using System.Collections;

public class LoadCharacterData : MonoBehaviour {

	SaveLoadDataSerialized loadData;
	private int level;
	private CharacterData playerData;

	void Start(){
		loadData = gameObject.GetComponent<SaveLoadDataSerialized> ();

		loadData.LoadChoosenCharacter ();
		loadData.Load ();

		GameObject player = GameObject.FindGameObjectWithTag (Tags.PLAYER);
		playerData = player.GetComponent<CharacterData> ();

		level = playerData.level;

	}

	void Update(){
		if (loadData.loaded) {
			LoadingScreen.isLoading = true;
			if(level <= 2){
				Application.LoadLevel(3);
			} else {
				Application.LoadLevel(level);
			}
		}
	}
}
