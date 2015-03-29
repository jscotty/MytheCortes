using UnityEngine;
using System.Collections;

public class ConfirmReject : MonoBehaviour {
	public GameObject confirmReject;
	private int _level;
	private int _mapLocation;

	public void confrim(string value){
		if(value == "door"){
			LoadLevel();
		}
	}

	public void reject(string value){
		confirmReject.SetActive (false);
	}

	public void LoadLevel(){
		QuestData.level = _level;
		QuestData.levelSpot = _mapLocation;
		LoadingScreen.isLoading = true;
		Application.LoadLevel(_level);
	}

	#region Getters and Setters
		public int level {
			get {
				return _level;
			}
			set {
				_level = value;
			}
		}
		
		public int mapLocation {
			get {
				return _mapLocation;
			}
			set {
				_mapLocation = value;
			}
		}
	#endregion
}
