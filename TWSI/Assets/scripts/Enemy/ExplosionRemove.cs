using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionRemove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(destroyExplosion());
    }

    IEnumerator destroyExplosion()
    {

        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
