using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firing : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject FireButton, bulletHolder, bulletHolder2, bulletHolder3, bullet, bullet2;

    public float waitingTime = .5f;
    float timePassed;

    public int weaponType = 0;
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
                

                //Different weapon behavior
                if(weaponType == 0)
                {
                    Instantiate(bullet, bulletHolder.transform.position, Quaternion.identity);
                }else if(weaponType == 1)
                {
                    Instantiate(bullet, bulletHolder.transform.position, Quaternion.identity);
                    Instantiate(bullet, bulletHolder2.transform.position, bulletHolder2.transform.rotation);
                    Instantiate(bullet, bulletHolder3.transform.position, bulletHolder3.transform.rotation);
                } 
                
            }
            
        }


    }
}
