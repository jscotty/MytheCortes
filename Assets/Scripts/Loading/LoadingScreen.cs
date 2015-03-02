using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour {
	
	public static bool isLoading;

	public GameObject loadImage;
	public Sprite[] images;

	void Start(){
		if (isLoading) {
			isLoading = false;
			loadImage.SetActive(false);
		}
	}

	void Update(){
		if (isLoading) {
			loadImage.SetActive(true);
			RandomImage();
		}
	}

	private void RandomImage(){
		float randImg = Random.Range (0, images.Length);
		int choosenImg = Mathf.FloorToInt(randImg);

		Image load = loadImage.GetComponent<Image> ();
		load.sprite = images [choosenImg];

	}
}
