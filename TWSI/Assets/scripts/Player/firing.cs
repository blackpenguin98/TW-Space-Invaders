using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firing : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject FireButton, bulletHolder, bullet;

    public float waitingTime = .5f;
    float timePassed;
    
    void Start()
    {
        timePassed = Mathf.Infinity;
    }

    // Update is called once per frame
    void Update()
    {

        timePassed += Time.deltaTime;

        if (FireButton.GetComponent<buttonFire>().firing || Input.GetButtonDown("Fire1"))
        {
            //Prevents player from spaming bullets
            if(timePassed >= waitingTime)
            {
                timePassed = 0;
                Debug.Log("patata");
                Instantiate(bullet, bulletHolder.transform.position, Quaternion.identity);
            }
            
        }


    }
}
