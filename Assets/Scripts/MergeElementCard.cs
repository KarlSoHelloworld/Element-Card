using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MergeElementCard : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        if (gameObject.tag == "ElementCard")
        {
            gameObject.tag = "ClickedElementCard";
            gameObject.transform.position += new Vector3(0f, 20f, 0f);
        }
        else if (gameObject.tag == "ClickedElementCard")
        {
            gameObject.tag = "ElementCard";
            gameObject.transform.position -= new Vector3(0f, 20f, 0f);
        }
    }
}
