using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag.name + "was dropped on" + gameObject.name);
        Draggable draggedCard = eventData.pointerDrag.GetComponent<Draggable>();
        if (draggedCard != null)
        {
            draggedCard.parentTransform = this.transform;
        }
    }
}
