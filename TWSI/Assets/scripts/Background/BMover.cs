using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMover : MonoBehaviour
{

    public float speed = 4f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }
}
