using UnityEngine;
using System.Collections;

public class MalincheController : MonoBehaviour {

	public GameObject[] fiew;
	public GameObject[] mapspot;

	private MoveToPlayer move;
	private float _dirX,_dirY;

	enum Side{Front,Back,SideL,SideR};

	void Start(){
		move = gameObject.GetComponent<MoveToPlayer> ();

		PosMalinche (QuestData.levelSpot);
	}

	void PosMalinche(int spot){
		gameObject.transform.position = mapspot [spot].transform.position;
	}

	void Update(){
		_dirX = move.dirX;
		_dirY = move.dirY;

		if(_dirX > 0){
			MoveRot(Side.SideR);
		} else if(_dirX < 0){
			MoveRot(Side.SideL);
		} else if(_dirY < 0){
			MoveRot(Side.Back);
		} else if(_dirY > 0){
			MoveRot(Side.Front);
		}
	}

	void MoveRot(Side side){
		if (side == Side.Back) {
			fiew[0].SetActive(true);
			fiew[1].SetActive(false);
			fiew[2].SetActive(false);
			fiew[3].SetActive(false);
		} else if (side == Side.Front) {
			fiew[0].SetActive(false);
			fiew[1].SetActive(true);
			fiew[2].SetActive(false);
			fiew[3].SetActive(false);
		} else if (side == Side.SideL) {
			fiew[0].SetActive(false);
			fiew[1].SetActive(false);
			fiew[2].SetActive(true);
			fiew[3].SetActive(false);
		} else if (side == Side.SideR) {
			fiew[0].SetActive(false);
			fiew[1].SetActive(false);
			fiew[2].SetActive(false);
			fiew[3].SetActive(true);
		}
	}
}
