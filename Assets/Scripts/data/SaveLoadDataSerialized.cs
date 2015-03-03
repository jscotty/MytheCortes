using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoadDataSerialized : MonoBehaviour {
	
	public CharacterData characterData;

	private SaveDataChoosenCharacter _saveDataChoosenCharacter;
	private ChoosenCharacter _choosenCharacter;

	private bool _loaded;

	void Start(){
		_saveDataChoosenCharacter = new SaveDataChoosenCharacter ();
		if (File.Exists (Application.persistentDataPath + _saveDataChoosenCharacter.savePath)) {
			Load();
		}
		_choosenCharacter = gameObject.GetComponent<ChoosenCharacter> ();
	}

	public void Save () {
		/*Binary formatter maakt de saved data binair waardoor het moeilijk te hacken
		 is voor de user*/
		if (File.Exists (Application.persistentDataPath + _saveDataChoosenCharacter.savePath)) {
			File.Delete (Application.persistentDataPath + _saveDataChoosenCharacter.savePath);
		}
		BinaryFormatter binaryFormatter = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + _saveDataChoosenCharacter.savePath); // ".dat" staat voor data, dit mag alle namen bevatten die nog geen extentie hebben in je hardware

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
		
		//Debug.Log ("Saved");
	}

	
	public void SaveChoosenCharacter () {
		/*Binary formatter maakt de saved data binair waardoor het moeilijk te hacken
		 is voor de user*/
		if (File.Exists (Application.persistentDataPath + Path.CHOOSEN_CHARACTER)) {
			File.Delete (Application.persistentDataPath + Path.CHOOSEN_CHARACTER);
		}

		BinaryFormatter binaryFormatter = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + Path.CHOOSEN_CHARACTER); // ".dat" staat voor data, dit mag alle namen bevatten die nog geen extentie hebben in je hardware

		_saveDataChoosenCharacter.savePath = _choosenCharacter.path;

		binaryFormatter.Serialize (file, _saveDataChoosenCharacter);
		file.Close ();
		
		//Debug.Log ("Saved");
	}

	public void LoadChoosenCharacter () {
		if (File.Exists (Application.persistentDataPath + Path.CHOOSEN_CHARACTER)) {
			BinaryFormatter binaryFormatter = new BinaryFormatter ();
			FileStream file = File.Open(Application.persistentDataPath + Path.CHOOSEN_CHARACTER, FileMode.Open);
			
			_saveDataChoosenCharacter = (SaveDataChoosenCharacter)binaryFormatter.Deserialize(file);
			//Debug.Log ("Loaded");
			_loaded = true;
			print("jah");
		}
		
	}

	public void Load () {
		if (File.Exists (Application.persistentDataPath + "/SaveData.dat")) {
			BinaryFormatter binaryFormatter = new BinaryFormatter ();
			FileStream file = File.Open(Application.persistentDataPath + "/SaveData.dat", FileMode.Open);

			
			if(characterData != null){
				SaveData saveData = (SaveData)binaryFormatter.Deserialize(file);
				characterData.health = saveData.health;
				characterData.gold = saveData.gold;
				characterData.level = saveData.level;
				characterData.quest = saveData.quest;
				characterData.questProgress = saveData.questProgress;
				characterData.questDone = saveData.questDone;
			}
			//Debug.Log ("Loaded");
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
public class SaveData{

	public int exp;
	public int health;
	public int gold;
	public int level;
	public int quest;
	public int questProgress;
	public int questDone;
}

[System.Serializable] 
public class SaveDataChoosenCharacter{
	public string savePath;
}
