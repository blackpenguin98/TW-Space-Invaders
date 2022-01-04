using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    } 


    public void LoadGame()
    {
        SceneManager.LoadScene(2);
    }
}
