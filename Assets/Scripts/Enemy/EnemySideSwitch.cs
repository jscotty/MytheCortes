using UnityEngine;
using System.Collections;

public class EnemySideSwitch : MonoBehaviour {

	public GameObject[] fiew;
	public MoveToPlayer move;
	public RandomWalking randMove;

	private float _dirX,_dirY;

	enum Side{Front,Back,Side,Side2};

	void Start(){
		if (move != null) {
			move = gameObject.GetComponent<MoveToPlayer>();
		} else if(randMove != null){
			randMove = gameObject.GetComponent<RandomWalking>();
		}
	}

	void Update(){
		if (move != null) {
			_dirX = move.dirX;
			_dirY = move.dirY;
		} else {
			_dirX = randMove.dirX;
			_dirY = randMove.dirY;
		}

		if(_dirX > 0){
			Rotate(Side.Side2);
		} else if(_dirX < 0){
			Rotate(Side.Side);
		} else if(_dirY > 0){
			Rotate(Side.Back);
		} else if(_dirY < 0){
			Rotate(Side.Front);
		}
	}

	void Rotate(Side side){
		switch (side) {
			case Side.Side:
			fiew[0].SetActive(false);
			fiew[1].SetActive(false);
			fiew[2].SetActive(true);
			fiew[3].SetActive(false);
				break;
			case Side.Side2:
			fiew[0].SetActive(false);
			fiew[1].SetActive(false);
			fiew[2].SetActive(false);
			fiew[3].SetActive(true);
				break;
		case Side.Front:
			fiew[0].SetActive(true);
			fiew[1].SetActive(false);
			fiew[2].SetActive(false);
			fiew[3].SetActive(false);
				break;
		case Side.Back:
			fiew[0].SetActive(false);
			fiew[1].SetActive(true);
			fiew[2].SetActive(false);
			fiew[3].SetActive(false);
				break;
			default:
					break;
		}
	}
}
