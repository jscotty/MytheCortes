using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProblemText : MonoBehaviour {
	public Text problem;
	public static string text;

	void Start(){
		problem.text = "------";
	}

	void Update(){
		problem.text = text;
	}

}
