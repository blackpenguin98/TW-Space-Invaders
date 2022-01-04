using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool pointerDownRigth;
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
        pointerDownRigth = true;
        //Debug.Log("OnPointerDown");
    }



    public void OnPointerUp(PointerEventData eventData)
    {
        pointerDownRigth = false;
        //Debug.Log("OnPointerUp");
    }
}
