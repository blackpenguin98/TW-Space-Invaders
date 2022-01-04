using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomDrop : MonoBehaviour
{

    public float speed = 4f;
    // Update is called once per frame


    private void Start()
    {
        StartCoroutine(destroyObject());
    }

    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {


            collision.GetComponent<firing>().weaponType = Random.Range(0, 2);
            collision.GetComponent<AudioSource>().Play();

            Destroy(gameObject);
        }
    }



    IEnumerator destroyObject()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }

}
