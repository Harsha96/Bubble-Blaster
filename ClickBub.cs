using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ClickBub : MonoBehaviour {

	int x;
	int count;
	TextMeshPro mytext;
	public static int p;
	GameObject textobj;
	public static string[] animals = {"Ant", "Cat","Cow","Dog","Lion"};
	public static string[] wrong = {"Hat","Bus","Pot","Boat","Pin"};
	// Scor e Variables
	public Text ScoreText;
	public  static int Score;
	public  static int life =0;
	public static int a;
   
    //[SerializeField]
    //private GameObject gameOverUI; 
	// Use this for initialization
	void Start () {
        
		textobj = this.gameObject.transform.GetChild (0).gameObject;
		mytext = textobj.GetComponent<TextMeshPro>();
	
		//soretext =textobj.AddComponent<TextMeshPro>();
	}
	void OnMouseDown(){
		Debug.Log ("click");
		Debug.Log(mytext.text);

		for(int i=0;i<5;i++){
			
			if (mytext.text.Equals(animals[i])) {
				Score = Score + 10;

			
				Debug.Log ("Win");
                if (Score == 200) {

                    Application.LoadLevel(Application.loadedLevel + 3);
                }
				
			}
			/*else {

				Debug.Log(life);
			}*/

		}
		for (int b=0; b<5; b++) {

			if(mytext.text.Equals(wrong[b])){
				life=life-1;
				Debug.Log("Lost");
			Debug.Log(a);
				if(life<-4){
                   // Application.LoadLevel(Application.game);
					Debug.Log("game over");

                 //   gameOverUI.SetActive(true);
                    SceneManager.LoadScene("Game Over");
                    life = 0;
                    Score = 0;
                }
			}
		}

		Destroy (gameObject);

	//count=count+10;

	

	}
	
	// Update is called once per frame
	void Update () {
		ScoreText.text = "Score:" + Score;

			//		life ;



}
	void OnDestroy(){
		Debug.Log (mytext.text);
		if (Input.GetMouseButtonDown (0)) {
		
		}	else{	for(int p = 0 ; p<5 ; p++){
				if (mytext.text.Equals(animals[p])){
				life=life-1;
					Debug.Log (life);
					Debug.Log ("wok");

			
			//Debug.Log (a);
	
		}
	}
		}
}

}