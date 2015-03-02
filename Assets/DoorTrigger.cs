using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {
	public Fader fader;

	[SerializeField]
	private int level;
	[SerializeField]
	private int questDone;

	SaveLoadDataSerialized _saveLoadData;
	TalkScript _talkScript;
	CharacterData _playerData;
	float _textIndex;
	float _fade;
	bool _fadeBool;

	void Start(){
		GameObject ui = GameObject.FindGameObjectWithTag (Tags.UI_CONTROLLER);
		_talkScript = ui.GetComponent<TalkScript> ();
		
		GameObject save = GameObject.FindGameObjectWithTag (Tags.SAVE);
		_saveLoadData = save.GetComponent<SaveLoadDataSerialized> ();

		GameObject player = GameObject.FindGameObjectWithTag (Tags.PLAYER);
		_playerData = player.GetComponent<CharacterData> ();
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == Tags.PLAYER) {

			if(_playerData.questDone >= questDone){
				_saveLoadData.Save();
				//_fadeBool = true;
				LoadLevel();
			} else {
				_textIndex ++;
				if(_textIndex == 1){
					_talkScript.StartTalk(other.name);
				}
			}
		}
	}

	void OnTriggerExit2D(Collider2D other){
		_textIndex = 0;
	}

	void LoadLevel(){
		//_fadeBool = false;
		LoadingScreen.isLoading = true;
		Application.LoadLevel(level);
	}
}
