using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoadDataSerialized : MonoBehaviour {
	public static int loadCheck;
	private bool _loaded;
	private int _level;

	void Start(){
		loadCheck ++;
		if (loadCheck == 1) {
			Load();	
		}
	}

	public void Save () {
		/*Binary formatter makes the saved data encrypted to binair so it is harder to hack*/
		BinaryFormatter binaryFormatter = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/SaveData.dat"); // ".dat" staat voor data, dit mag alle namen bevatten die nog geen extentie hebben in je hardware
		
		CharacterData characterData = new CharacterData();
		characterData.quest = QuestData.quest;
		characterData.questProgress = QuestData.questProgress;
		characterData.questDone = QuestData.questDone;
		characterData.level = Application.loadedLevel;
		characterData.potions = PickupData.potions;
		characterData.levelSpot = QuestData.levelSpot;
		characterData.soundOn = OptionsHandler.SoundOn;
		characterData.npcKills = UserStats.npcKills;
		characterData.questItems = QuestData.questItems;
		characterData.health = PlayerData.health;
		
		binaryFormatter.Serialize (file, characterData);
		file.Close ();

		Load ();
	}

	public void Load () {
		_loaded = true;
		if (File.Exists (Application.persistentDataPath + "/SaveData.dat")) {
			BinaryFormatter binaryFormatter = new BinaryFormatter ();
			FileStream file = File.Open(Application.persistentDataPath + "/SaveData.dat", FileMode.Open);

			CharacterData characterData = (CharacterData)binaryFormatter.Deserialize(file);
			//	playerController.PosPlayer();
			QuestData.quest = characterData.quest;
			QuestData.questProgress = characterData.questProgress;
			QuestData.questDone = characterData.questDone;
			QuestData.level = characterData.level;
			QuestData.levelSpot = characterData.levelSpot;
			PickupData.potions = characterData.potions;
			OptionsHandler.SoundOn = characterData.soundOn;
			UserStats.npcKills = characterData.npcKills;
			QuestData.questItems = characterData.questItems;
			PlayerData.health = characterData.health;

			if(PlayerData.health <= 0){
				PlayerData.health = 500;
			}

			_level = characterData.level;


		} else {
			_level = 3;
			_loaded = true;
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

	public int level{
		get {
			return _level;
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
	public int levelSpot;
}

[System.Serializable] 
public class SaveDataChoosenCharacter {
	public string savePath;
}
