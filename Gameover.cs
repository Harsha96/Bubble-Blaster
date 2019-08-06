using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour {

    public void Quit() {
        Debug.Log("Application Quit");
        Application.Quit();
    }
    public void Retry(string retry) {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        SceneManager.LoadScene(retry);
       // SceneManager.LoadScene("Level1");
       // Application.LoadLevel("Level1");
    }
    public void restart() {
        Application.LoadLevel(Application.loadedLevel+1);
    }
    public void Menubtn(string newmenu)
    {

        SceneManager.LoadScene(newmenu);
    }
}
