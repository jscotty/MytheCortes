using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoadDataSerialized : MonoBehaviour {

	public void Save () {
		/*Binary formatter maakt de saved data binair waardoor het moeilijk te hacken
		 is voor de user*/
		BinaryFormatter binaryFormatter = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + Path.SAVE_DATA_PATH); // ".dat" staat voor data, dit mag alle namen bevatten die nog geen extentie hebben in je hardware

		GameObject player = GameObject.FindGameObjectWithTag (Tags.PLAYER);
		CharacterData playerData = player.GetComponent<CharacterData> ();

		binaryFormatter.Serialize (file, playerData);
		file.Close ();

		Debug.Log ("Saved");
	}
	
	public void Load () {
		if (File.Exists (Application.persistentDataPath + Path.SAVE_DATA_PATH)) {
			BinaryFormatter binaryFormatter = new BinaryFormatter ();
			FileStream file = File.Open(Application.persistentDataPath + Path.SAVE_DATA_PATH, FileMode.Open);

			CharacterData playerData = (CharacterData)binaryFormatter.Deserialize(file);
			//resources.SetGold(saveData.gold);
			Debug.Log ("Loaded");
		}

	}
}
[System.Serializable] // zorgt ervoor dat je die kan wegschrijven naar unity
public class SaveData{
	
	public Vector2 position;
	public int exp;
	public int health;
	public int gold;
	public int level;
	public int quest;
	public int questProgress;
}
