using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public float distanceMultiplier;

    // Update is called once per frame
    public GameObject explosion, randomWeapon;
    void Update()
    {

        distanceMultiplier = Vector2.Distance(GameObject.Find("Player").transform.position, transform.position);
        
        if(GetComponent<EnemyMetadata>().health <= 0)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);

            //Instantiates random weapon powerUP

            int probability = Random.Range(0, 10);
            if(probability > 6)
            {
                Instantiate(randomWeapon, transform.position, Quaternion.identity);
            }

           


            //Score


            if(distanceMultiplier >= 5.9)
            {
                GameManager.instance.score += GetComponent<EnemyMetadata>().points * 3;
            } else
            {
                GameManager.instance.score += GetComponent<EnemyMetadata>().points;
            }
            





            Destroy(gameObject);
        }



    }
}
