using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float speed = 5f;
    public GameObject buttonR, buttonL;

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
        if (buttonR.GetComponent<button>().pointerDownRigth || Input.GetAxis("Horizontal") > 0)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }

        if (buttonL.GetComponent<buttonLeft>().pointerDownLeft || Input.GetAxis("Horizontal") < 0)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
    }


}
