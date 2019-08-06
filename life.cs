using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class life : MonoBehaviour {
	
	
	public float currprog;
	public float maxprog;
	public Slider Pro;
	public int a=0;
	
	// Use this for initialization
	void Start () {
		
		maxprog = 5f;
		
		currprog = 0f;
		Pro.value = calprog ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (a == ClickBub.life || a == ClickBubble2.life) {

			if (Input.GetMouseButtonDown (0)) {
				Deal (1);
				
				Debug.Log (a);
			}

			a = a - 1;
			if (tag == "Bubble") {
				Destroy (gameObject);
				Debug.Log (a);
			}
		}
			
	
		
	}
	
	void Deal(float save){
		
		currprog += save;
		Pro.value = calprog ();
		
		
		if (currprog > maxprog)
			Die ();
		
	}
	
	float calprog(){
		return currprog / maxprog;
	}
	
	
	void Die(){
		Debug.Log ("Game over");
	}


	
}
