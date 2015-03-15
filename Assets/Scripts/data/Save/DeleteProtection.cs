using UnityEngine;
using System.Collections;

public class DeleteProtection : MonoBehaviour {

	public GameObject sureOrNot;
	private DeleteSave _deleteSave;

	void Start(){
		_deleteSave = gameObject.GetComponent<DeleteSave> ();
	}

	public void Confirm(){
		int value = _deleteSave.saveFile;
		_deleteSave.Delete (value);

		sureOrNot.SetActive (false);
	}

	public void Reject(){
		sureOrNot.SetActive (false);
	}
}
