﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BubbleDestroy : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Bubble") {
			Destroy(other.gameObject);
		
		}
}
}
