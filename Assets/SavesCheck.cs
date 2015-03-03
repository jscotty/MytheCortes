using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SavesCheck : MonoBehaviour {

	public Text[] savedFileText;
	private string[] charnames = new string[]{"CharA", "CharB", "CharC", "Empty"};

	private int _character;
	private string _path;

	private ChoosenCharacter _choosenCharacter;


	void Start(){
		_choosenCharacter = gameObject.GetComponent<ChoosenCharacter> ();
		CheckSaves ();
	}

	public void ChooseCharacter(int value){
		if (value == 1) {
			_path = Path.SAVE_DATA_PATH;
		} else if (value == 2) {
			_path = Path.SAVE_DATA_PATH2;
		} else if (value == 3) {
			_path = Path.SAVE_DATA_PATH3;
		}

		_choosenCharacter.StartChoosenCharacter ();
	}

	public void Delete(int btn){
		if (btn == 1) {
			if (File.Exists (Application.persistentDataPath + "/SaveData.dat")){
				File.Delete (Application.persistentDataPath + "/SaveData.dat"); 
				savedFileText[0].text = charnames[3];
				CheckSaves ();
			}
		} else if (btn == 2) {
			if (File.Exists (Application.persistentDataPath + "/SaveData2.dat")){
				File.Delete (Application.persistentDataPath + "/SaveData2.dat");
				savedFileText[1].text = charnames[3];
				CheckSaves ();
			}
		} else if (btn == 3) {
			if (File.Exists (Application.persistentDataPath + "/SaveData3.dat")){
				File.Delete (Application.persistentDataPath + "/SaveData3.dat");
				savedFileText[2].text = charnames[3];
				CheckSaves ();
			}
		}
	}

	void CheckSaves(){
		if (File.Exists (Application.persistentDataPath + "/SaveData.dat")) 
			savedFileText[0].text = charnames[0];
		if (File.Exists (Application.persistentDataPath + "/SaveData2.dat")) 
			savedFileText[1].text = charnames[1];
		if (File.Exists (Application.persistentDataPath + "/SaveData3.dat")) 
			savedFileText[2].text = charnames[2];
	}

	#region getters and setters
	public string path {
		get{
			return _path;
		}
		set{
			_path = value;
		}
	}
	#endregion
}
