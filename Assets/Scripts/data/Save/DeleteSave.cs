using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class DeleteSave : MonoBehaviour {

	public GameObject sureOrNot;
	SavesCheck _saveCheck;
	private int _saveFile;

	void Start(){
		_saveCheck = gameObject.GetComponent<SavesCheck> ();
	}

	public void SentDelete(int btn){
		_saveFile = btn;
		sureOrNot.SetActive (true);
	}
	
	public void Delete(int file){
		if (file == 1) {
			if (File.Exists (Application.persistentDataPath + "/SaveData.dat")){
				File.Delete (Application.persistentDataPath + "/SaveData.dat"); 
				_saveCheck.savedFileText[0].text = _saveCheck.charnames[3];
				_saveCheck.CheckSaves ();
			}
		} else if (file == 2) {
			if (File.Exists (Application.persistentDataPath + "/SaveData2.dat")){
				File.Delete (Application.persistentDataPath + "/SaveData2.dat");
				_saveCheck.savedFileText[1].text = _saveCheck.charnames[3];
				_saveCheck.CheckSaves ();
			}
		} else if (file == 3) {
			if (File.Exists (Application.persistentDataPath + "/SaveData3.dat")){
				File.Delete (Application.persistentDataPath + "/SaveData3.dat");
				_saveCheck.savedFileText[2].text = _saveCheck.charnames[3];
				_saveCheck.CheckSaves ();
			}
		}
	}

	#region getters and setters
	
	public int saveFile {
		get {
			return _saveFile;
		}
		set {
			_saveFile = value;
		}
	}

	#endregion

}
