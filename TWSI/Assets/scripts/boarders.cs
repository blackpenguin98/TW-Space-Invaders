using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boarders : MonoBehaviour
{


    // Update is called once per frame
    private void Update()
    {
        //Clamps the position of the ship to the screen width and height
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.5f, 2.5f), transform.position.y, transform.position.z);
    }
}
