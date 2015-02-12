using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HitPointsScript : MonoBehaviour {
	
	public RectTransform healthTransform;

	private float cachedY;
	private float minXValue;
	private float maxXValue;
	private int currentHealth;

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
	private bool onCD;
	
	
	void Start(){
		health = 500;
		cachedY = healthTransform.position.y;
		maxXValue = healthTransform.position.x;
		minXValue = -healthTransform.position.x + healthTransform.rect.width - 30f;

		currentHealth = maxHealth;
		onCD = false;
		
	}
	
	void Update(){
		HandleHealth ();

		currentHealth = health;
	}
	
	private void HandleHealth(){
		float currentXValue = MapValues (currentHealth, 0, maxHealth, minXValue, maxXValue);
		healthTransform.position = new Vector3 (currentXValue, cachedY);
		
		if (currentHealth > maxHealth/2) {
			visualHealth.color = new Color32((byte)MapValues(currentHealth,maxHealth/2,maxHealth,255,0), 203, 0, 255);
		}else {
			visualHealth.color = new Color32(255,(byte)MapValues(currentHealth,0,maxHealth/2,0,255), 0, 255);
		}
	}
	
	private float MapValues(float x, float inMin, float inMax, float outMin, float outMax){
		return (x - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
	}
}
