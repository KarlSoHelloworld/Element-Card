using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler,IEndDragHandler {

    //the offset between mouse and center of card.
    Vector3 offset=Vector3.zero;

    //after dragging, the card's parent will be parentTransform
    public Transform parentTransform=null;
    
    //start dragging
    public void OnBeginDrag(PointerEventData eventData)
    {        
        //Debug.Log("Start Dragging");   

        offset = this.transform.position - (Vector3)eventData.position;
        parentTransform = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    //dragging
    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("Dragging");
        this.transform.position = (Vector3)eventData.position + offset;
    }

    //stop dragging
    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("Stop Dragging");
        this.transform.SetParent(parentTransform);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }


}
