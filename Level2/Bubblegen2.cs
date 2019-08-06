using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Bubblegen2 : MonoBehaviour {
    public static string[] wordsa = { "Car", "Red", "Hat", "Bus", "Pot", "Lion", "Bike", "Cow", "Van", "Jeep" };

    public GameObject bubble;

    public bool stopSpawning = false;
    public float Spawntime;
    public float spawndelay;

    public TextMeshPro textbubble1;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnObject", Spawntime, spawndelay);

    }
    public void SpawnObject()
    {
        Instantiate(bubble, transform.position, transform.rotation);

        int num = Random.Range(0, 9);


        //Debug.Log (num);
        textbubble1.text = wordsa[num];
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }

    }

}
