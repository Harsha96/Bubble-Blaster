using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clone : MonoBehaviour {
	public GameObject mes;
	public bool stopSpawning = false;
	public float Spawntime;
	public float spawndelay;
	Vector3 temp;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnObject", Spawntime, spawndelay);
	}
	
	// Update is called once per frame
	public void SpawnObject () {
		Instantiate (mes, transform.position, transform.rotation);

	}

	void OnCollisionEnter2D(Collision2D col){
		temp = transform.position;
		if(temp.y == -7f)
		{
			Destroy (gameObject);
		}
	}
}
