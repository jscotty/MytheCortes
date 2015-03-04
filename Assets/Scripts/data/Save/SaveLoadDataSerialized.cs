using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoadDataSerialized : MonoBehaviour {
	
	public CharacterData characterData;

	private SaveDataChoosenCharacter _saveDataChoosenCharacter;
	private ChoosenCharacter _choosenCharacter;

	private bool _loaded;

	private string _savePath;

	void Start(){
		_saveDataChoosenCharacter = new SaveDataChoosenCharacter ();

		_choosenCharacter = gameObject.GetComponent<ChoosenCharacter> ();
		if (File.Exists (Application.persistentDataPath + Path.CHOOSEN_CHARACTER)) {
			LoadChoosenCharacter();
		}
		if (File.Exists (Application.persistentDataPath + _savePath)) {
			Load();
		}
	}

	void StartSaves(){
		_savePath = _saveDataChoosenCharacter.savePath;
	}

	public void Save () {
		/*Binary formatter makes the saved data encrypted to binair so it is harder to hack*/
		//print (_savePath);
		/*if (File.Exists (Application.persistentDataPath + _savePath)) {
			File.Delete (Application.persistentDataPath + _savePath);
		}*/

		BinaryFormatter binaryFormatter = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + _savePath); // ".dat" staat voor data, dit mag alle namen bevatten die nog geen extentie hebben in je hardware

		SaveData saveData = new SaveData();
		if(characterData != null){
			saveData.health = characterData.health;
			saveData.gold = characterData.gold;
			saveData.level = characterData.level;
			saveData.quest = characterData.quest;
			saveData.questProgress = characterData.questProgress;
			saveData.questDone = characterData.questDone;

		}
		
		binaryFormatter.Serialize (file, saveData);
		file.Close ();
		StartSaves ();
		
		//Debug.Log ("Saved");
	}
	
	public void SaveChoosenCharacter () {
		/*Binary formatter makes the saved data encrypted to binair so it is harder to hack*/

		BinaryFormatter binaryFormatter = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + Path.CHOOSEN_CHARACTER); // ".dat" staat voor data, dit mag alle namen bevatten die nog geen extentie hebben in je hardware

		_saveDataChoosenCharacter.savePath = _choosenCharacter.path;
		_savePath = _saveDataChoosenCharacter.savePath;
		
		binaryFormatter.Serialize (file, _saveDataChoosenCharacter);
		file.Close ();
		StartSaves ();
		
		//print("Saved choos char data");
		//Debug.Log ("Saved");
	}

	public void LoadChoosenCharacter () {
		if (File.Exists (Application.persistentDataPath + Path.CHOOSEN_CHARACTER)) {
			BinaryFormatter binaryFormatter = new BinaryFormatter ();
			FileStream file = File.Open(Application.persistentDataPath + Path.CHOOSEN_CHARACTER, FileMode.Open);
			
			_saveDataChoosenCharacter = (SaveDataChoosenCharacter)binaryFormatter.Deserialize(file);
			_savePath = _saveDataChoosenCharacter.savePath;
			_loaded = true;
			StartSaves ();
			//print("Loaded choos char data");
		}
		
	}

	public void Load () {
		if (File.Exists (Application.persistentDataPath + _savePath)) {
			BinaryFormatter binaryFormatter = new BinaryFormatter ();
			FileStream file = File.Open(Application.persistentDataPath + _savePath, FileMode.Open);

			
			if(characterData != null){
				SaveData saveData = (SaveData)binaryFormatter.Deserialize(file);
				characterData.health = saveData.health;
				characterData.gold = saveData.gold;
				characterData.level = saveData.level;
				characterData.quest = saveData.quest;
				characterData.questProgress = saveData.questProgress;
				characterData.questDone = saveData.questDone;
				//print ("load data");
			}
			//print ("loaded");
			//Debug.Log ("Loaded");
			StartSaves ();
		}
		
	}
	#region getters and setters
	public bool loaded{
		get {
			return _loaded;
		}
		set {
			_loaded = value;
		}
	}
	#endregion
}
[System.Serializable] 
public class SaveData {
	public int exp;
	public int health;
	public int gold;
	public int level;
	public int quest;
	public int questProgress;
	public int questDone;
}

[System.Serializable] 
public class SaveDataChoosenCharacter {
	public string savePath;
}
