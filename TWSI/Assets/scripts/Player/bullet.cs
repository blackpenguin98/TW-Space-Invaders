using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float speed = 6f;

    float waitingTime = 4f;
    float timePassed = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        //Destroys bullet after some time

        timePassed += Time.deltaTime;

        if(timePassed > waitingTime)
        {
            Destroy(gameObject);
        }


       
    }


    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "enemy")
        {
            collision.GetComponent<AudioSource>().Play();
            collision.GetComponent<EnemyMetadata>().health--;
            Destroy(gameObject);
        }
    }

}
