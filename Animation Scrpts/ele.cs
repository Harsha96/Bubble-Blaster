using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ele : MonoBehaviour {
	Animator anim;
	float maxValue = 6; // or whatever you want the max value to be
	float minValue = -6; // or whatever you want the min value to be
	float currentValue = -3; // or wherever you want to start
	float direction = 1; 
	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		currentValue += Time.deltaTime * direction; // or however you are incrementing the position
		if (currentValue >= maxValue) {
			direction *= -1;
			currentValue = maxValue;
		} else if (currentValue <= minValue) {
			direction *= -1; 
			currentValue = minValue;
			anim.transform.Rotate (0, 180, 0);
		}
		anim.transform.position = new Vector3(currentValue, 0, 0);
		if (currentValue == 6)  {
			anim.transform.Rotate (0, 180, 0);
			//anim.gameObject.GetComponent<Animator>().enabled = false;
		} else if(currentValue == -7){
			anim.transform.Rotate (0, 180, 0);
			
		}
	}
}
