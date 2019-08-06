using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
	public Text ScoreText;
	public static int Score;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ScoreText.text = "Score:" + Score;
		//if(Input.GetMouseButtonDown(0)){
		//Score = Score + 10;
		//}
	}
	
	public void scoreplus(){
		Score = Score + 10;
	}
}
