using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BubbleGen : MonoBehaviour {
	public static string[] words = {   "Ant", "Cat","Hat","Bus","Pot","Lion","Boat","Cow","Pin","Dog"};
	
	public GameObject bubble;

	public bool stopSpawning = false;
	public float Spawntime;
	public float spawndelay;
	
	public TextMeshPro textbubble;
	
	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnObject", Spawntime, spawndelay);
		
	}
	public void SpawnObject(){
		Instantiate (bubble, transform.position, transform.rotation);
	
		int num = Random.Range(0,9);


		//Debug.Log (num);
		textbubble.text = words[num];
		if(stopSpawning)
		{
			CancelInvoke("SpawnObject");
		}

	}

}	
