using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {
	public Fader fader;

	[SerializeField]
	private int _level;
	[SerializeField]
	private int _questDone;
	[SerializeField]
	private int _mapLocation;

	private SaveLoadDataSerialized _saveLoadData;
	private TalkScript _talkScript;
	private CharacterData _playerData;
	private float _textIndex;
	private float _fade;
	private bool _fadeBool;



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

			if(_playerData.questDone >= _questDone){
				print("level: " + _level);
				_playerData.level = _level;
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
		Application.LoadLevel(_level);
	}

	#region getter and setter
	public int mapLocation{
		get {
			return _mapLocation;
		}
		set {
			_mapLocation = value;
		}
	}
	#endregion
}
