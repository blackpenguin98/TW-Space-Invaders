using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelHandler : MonoBehaviour
{
    public GameObject Level1L, Level2L;
    public float speed;


    private void Start()
    {
        if(GameManager.instance.layout == 1)
        {
            speed = 0.2f;
            Level1L.SetActive(true);

        }
        else
        {
            speed = 0.6f;
            Level2L.SetActive(true);
        }
    }


}
