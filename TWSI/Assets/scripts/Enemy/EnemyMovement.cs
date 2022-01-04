using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    float speed;


    // Update is called once per frame
    void Update()
    {
        speed = GameObject.Find("LevelHandler").GetComponent<levelHandler>().speed;
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            SceneManager.LoadScene(3);
        }
    }

}
