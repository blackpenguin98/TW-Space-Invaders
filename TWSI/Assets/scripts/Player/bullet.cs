using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float speed = 6f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }


    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }
}
