using UnityEngine;
using System.Collections;

public class DummyBehaviour : MonoBehaviour {

	private bool damaging;
	SpriteRenderer spriteRenderer;

	void Start(){
		spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
	}

	void Update(){
		if (damaging) {
			spriteRenderer.color = Color.yellow;
		} else {
			spriteRenderer.color = Color.red;
		}
	}

	#region getters and setters
	public bool GetDamaging(){
		return damaging;
	}
	public void SetDamaging(bool value){
		damaging = value;
	}
	#endregion
}
