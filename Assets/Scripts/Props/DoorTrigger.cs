using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {
	public Fader fader;
	public GameObject confirmRejectObject;
	public ConfirmReject confirmReject;

	[SerializeField]
	private int _level;
	[SerializeField]
	private int _questDone;
	[SerializeField]
	private int _mapLocation;
	[SerializeField]
	private bool _danger;

	private TalkScript _talkScript;
	private float _textIndex;
	private float _fade;
	private bool _fadeBool;

	void Start(){
		GameObject ui = GameObject.FindGameObjectWithTag (Tags.UI_CONTROLLER);
		confirmReject = ui.GetComponent<ConfirmReject> ();
		_talkScript = ui.GetComponent<TalkScript> ();
	}


	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == Tags.PLAYER) {
			if(_danger){
				confirmRejectObject.SetActive(true);
				ConfrimData();
			}else{
				if(QuestData.questDone >= _questDone){
					ConfrimData();
					confirmReject.LoadLevel();
					//_saveLoadData.Save();
					//_fadeBool = true;
				} else {
					_textIndex ++;
					if(_textIndex == 1){
						_talkScript.StartTalk(other.name);
					}
				}

			}
		}
	}

	void ConfrimData(){
		confirmReject.level = _level;
		confirmReject.mapLocation = _mapLocation;
	}

	void OnTriggerExit2D(Collider2D other){
		_textIndex = 0;
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
