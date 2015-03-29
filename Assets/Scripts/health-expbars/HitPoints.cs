using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HitPoints : MonoBehaviour {
	
	public RectTransform healthTransform;

	private float cachedY;
	private float minXValue;
	private float maxXValue;
	private int currentHealth;
	public Text healtText;

	public int health;

	private int CurrentHealth
	{
		get{ return currentHealth; }
		set{ currentHealth = value; 
			HandleHealth();
		}
	}
	
	public int maxHealth;
	
	public Image visualHealth;
	
	
	void Start(){
		health = 500;
		cachedY = healthTransform.position.y;
		maxXValue = healthTransform.position.x;
		minXValue = healthTransform.rect.width;

		currentHealth = maxHealth;
		
	}
	
	void Update(){
		HandleHealth ();

		currentHealth = PlayerData.health;

		healtText.text = currentHealth + " / " + maxHealth;
	}
	
	private void HandleHealth(){
		float currentXValue = MapValues (currentHealth, 0, maxHealth, minXValue, maxXValue);
		healthTransform.position = new Vector3 (currentXValue, cachedY);
		
		if (currentHealth > maxHealth/2) {
			//visualHealth.color = new Color32(255,0,255, 255);
		}else {
		//	visualHealth.color = new Color32(255,61, 0, 255);
		}
	}
	
	private float MapValues(float x, float inMin, float inMax, float outMin, float outMax){
		return (x - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
	}
}
