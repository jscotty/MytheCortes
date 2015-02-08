using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class DataClass : MonoBehaviour {

	string savePath;

	void Start () {
		DontDestroyOnLoad (gameObject);
		savePath = Application.persistentDataPath;
		print (savePath);
	}
}
