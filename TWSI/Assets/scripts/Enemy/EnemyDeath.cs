using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{


    // Update is called once per frame
    public GameObject explosion, randomWeapon;
    void Update()
    {
        
        if(GetComponent<EnemyMetadata>().health <= 0)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);

            //Instantiates random weapon powerUP

            int probability = Random.Range(0, 10);
            if(probability > 6)
            {
                Instantiate(randomWeapon, transform.position, Quaternion.identity);
            }

            Debug.Log(probability);


            //

            GameManager.instance.score += GetComponent<EnemyMetadata>().points;
            Destroy(gameObject);
        }



    }
}
