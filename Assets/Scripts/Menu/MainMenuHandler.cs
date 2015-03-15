using UnityEngine;
using System.Collections;

public class MainMenuHandler : MonoBehaviour {

	public GameObject[] panels;

	public void Credits(){
		panels [0].SetActive (false);
		panels [1].SetActive (true);
	}
}
