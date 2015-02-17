using UnityEngine;
using System.Collections;

public class DummyBehaviour : MonoBehaviour {

	private bool damaging;
	SpriteRenderer spriteRenderer;
	CharacterData _playerData;

	void Start(){
		spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();

		GameObject player = GameObject.FindGameObjectWithTag (Tags.PLAYER);
		_playerData = player.GetComponent<CharacterData> ();
	}

	void Update(){
		if (damaging) {
			spriteRenderer.color = Color.yellow;
			if(_playerData.quest == 1 && _playerData.questProgress < 100){
				_playerData.questProgress = 100;
			}
		} else {
			spriteRenderer.color = Color.white;
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
