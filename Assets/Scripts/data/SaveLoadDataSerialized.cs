using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoadDataSerialized : MonoBehaviour {

	//public Resources resources;
	
	public void Save () {
		/*Binary formatter maakt de saved data binair waardoor het moeilijk te hacken
		 is voor de user*/
		BinaryFormatter binaryFormatter = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/SaveData.dat"); // ".dat" staat voor data, dit mag alle namen bevatten die nog geen extentie hebben in je hardware

		SaveData saveData = new SaveData();
		//saveData.gold = resources.getGold();

		binaryFormatter.Serialize (file, saveData);
		file.Close ();

		Debug.Log ("Saved");
	}
	
	public void Load () {
		if (File.Exists (Application.persistentDataPath + "/SaveData.dat")) {
			BinaryFormatter binaryFormatter = new BinaryFormatter ();
			FileStream file = File.Open(Application.persistentDataPath + "/SaveData.dat", FileMode.Open);

			SaveData saveData = (SaveData)binaryFormatter.Deserialize(file);
			//resources.SetGold(saveData.gold);
			Debug.Log ("Loaded");
		}

	}
}
[System.Serializable] // zorgt ervoor dat je die kan wegschrijven naar unity
public class SaveData{
	public int gold;
}
