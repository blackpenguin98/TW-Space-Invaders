using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
   public void LoadCredits()
    {
        SceneManager.LoadScene(1);
    }

    public void Layout1()
    {
        GameManager.instance.layout = 1;
        SceneManager.LoadScene(2);
    }


    public void Layout2()
    {
        GameManager.instance.layout = 2;
        SceneManager.LoadScene(2);
    }


}
