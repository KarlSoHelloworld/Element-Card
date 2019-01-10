using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[ExecuteInEditMode]

public class MouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    //Mouse over The card front
    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("Mouse Over");

        //get the parent transform
        Transform parentTransform = this.transform.parent.parent;

        //bigger the card
        parentTransform.localScale = new Vector3(1, 1, 1);

        //show buff list
        GameObject buffList = parentTransform.Find("BuffList").gameObject;
        buffList.SetActive(true);
    }

    //Mouse leave The card front
    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("Mouse Exit");

        Transform parentTransform = this.transform.parent.parent;
        //smaller the card
        parentTransform.localScale = new Vector3(0.4f, 0.4f, 0.4f);

        //hide buff list
        GameObject buffList = parentTransform.Find("BuffList").gameObject;
        buffList.SetActive(false);
    }

}
