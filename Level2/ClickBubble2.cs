using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickBubble2 : MonoBehaviour {

    int x;
    int count;
    TextMeshPro mytext;
    public static int p;
    GameObject textobj;
    public static string[] vehicals = { "Car", "Bus", "Bike", "Van", "Jeep" };
    public static string[] wrong = { "Red", "sun", "Pot", "Lion", "Cow" };
    // Scor e Variables
    public Text ScoreText;
    public static int Score=200;
    public static int life = 0;
    public static int a;

    void Start()
    {

        textobj = this.gameObject.transform.GetChild(0).gameObject;
        mytext = textobj.GetComponent<TextMeshPro>();

        //soretext =textobj.AddComponent<TextMeshPro>();
    }
    void OnMouseDown()
    {
        Debug.Log("click");
        Debug.Log(mytext.text);

        for (int i = 0; i < 5; i++)
        {

            if (mytext.text.Equals(vehicals[i]))
            {
                Score = Score + 10;


                Debug.Log("Win");


            }
            /*else {

                Debug.Log(life);
            }*/

        }
        for (int b = 0; b < 5; b++)
        {

            if (mytext.text.Equals(wrong[b]))
            {
                life = life - 1;
                Debug.Log("Lost");
                Debug.Log(a);
                if (life < -4)
                {
                   
                    Debug.Log("game over");

                    //   gameOverUI.SetActive(true);
                    SceneManager.LoadScene("Game Over");
                    life = 0;
                    Score = 0;
                }
            }
        }

        Destroy(gameObject);

        //count=count+10;



    }

    // Update is called once per frame
    void Update()
    {
		ScoreText.text = "Score:" + Score;

        //		life ;



    }
}

