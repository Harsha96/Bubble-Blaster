using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Btnmanager : MonoBehaviour {

    public void newgamebtn(string newgamelevel) {


        SceneManager.LoadScene(newgamelevel);
    }

    public void newoptionsbtn(string newgameoption) {

        SceneManager.LoadScene(newgameoption);
    }
    public void exitbtn()
    {
        Application.Quit();
    }
    public void Level1t(string level1tu)
    {

        SceneManager.LoadScene(level1tu);
    }
    public void Level2(string level2)
    {
        if(names.l>19){
        SceneManager.LoadScene(level2);
        }

        
    }
}
