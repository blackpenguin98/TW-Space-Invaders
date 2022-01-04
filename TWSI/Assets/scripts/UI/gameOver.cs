using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public void LoadMenu()
    {
        GameManager.instance.score = 0;
        SceneManager.LoadScene(0);
    } 


    public void LoadGame()
    {
        GameManager.instance.score = 0;
        SceneManager.LoadScene(2);
    }
}
