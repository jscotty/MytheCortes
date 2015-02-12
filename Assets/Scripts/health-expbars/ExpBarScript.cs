using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ExpBarScript : MonoBehaviour {
	
	public RectTransform expTransform;
	
	private float cachedY;
	private float minXValue;
	private float maxXValue;
	private int currentExp;
	
	public int exp;
	
	
	private int CurrentExp
	{
		get{ return currentExp; }
		set{ currentExp= value; 
			HandleExp();
		}
	}
	
	public int maxExp;
	
	public Image visualExp;
	private bool onCD;
	
	
	void Start(){
		exp = 0;
		cachedY = expTransform.position.y;
		minXValue = expTransform.position.x;
		maxXValue = expTransform.position.x + 86f;
		
		currentExp = maxExp;
		onCD = false;
		
	}
	
	void Update(){
		HandleExp ();
		
		currentExp = exp;
	}
	
	private void HandleExp(){
		float currentXValue = MapValues (currentExp, 0, maxExp, minXValue, maxXValue);
		expTransform.position = new Vector3 (currentXValue, cachedY);

	}
	
	private float MapValues(float x, float inMin, float inMax, float outMin, float outMax){
		return (x - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
	}
}