using UnityEngine;
using System.Collections;

public class ChoosenCharacter : MonoBehaviour {

	SavesCheck saveCheck;
	public SaveLoadDataSerialized saveData;
	private int _character;
	private string _path;

	public void StartChoosenCharacter () {
		saveCheck = gameObject.GetComponent<SavesCheck> ();
		//_path = saveCheck.path;

		//saveData.SaveChoosenCharacter ();

		LoadingScreen.isLoading = true;
		Application.LoadLevel (2);
	}

	#region getter and setter
	
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
