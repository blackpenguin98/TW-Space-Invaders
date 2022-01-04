using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class buttonLeft : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool pointerDownLeft;
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
        pointerDownLeft = true;
        //Debug.Log("OnPointerDown");
    }



    public void OnPointerUp(PointerEventData eventData)
    {
        pointerDownLeft = false;
        //Debug.Log("OnPointerUp");
    }
}
