using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class buttonFire : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool firing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        firing = true;
        //Debug.Log("OnPointerDown");
    }



    public void OnPointerUp(PointerEventData eventData)
    {
        firing = false;
        //Debug.Log("OnPointerUp");
    }
}
