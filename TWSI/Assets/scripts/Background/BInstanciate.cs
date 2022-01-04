using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BInstanciate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject background, spawn;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(background, spawn.transform.position, Quaternion.identity);
    }
}
