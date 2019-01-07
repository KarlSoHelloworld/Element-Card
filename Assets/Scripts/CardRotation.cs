using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]

public class CardRotation : MonoBehaviour {

    public RectTransform cardFront;
    public RectTransform cardBack;

    public Transform targetFacePosition;

    public Collider col;

    private bool showingBack = false;
    private void Awake()
    {

    }
    // Update is called once per frame
    void Update () {

        RaycastHit[] hits;
        hits = Physics.RaycastAll(origin: Camera.main.transform.position+targetFacePosition.position,
            direction: (-Camera.main.transform.position + targetFacePosition.position).normalized,
            maxDistance: (-Camera.main.transform.position + targetFacePosition.position).magnitude);
        
        bool passThroughTargetCollider = false;

        //Debug.Log("--------------------------------------");
        //Debug.Log("Camera:" + Camera.main.transform.position);
        //Debug.Log("targetFacePosition:" + targetFacePosition.position);
        //Debug.Log("Origin:" + (Camera.main.transform.position + targetFacePosition.position));
        //Debug.Log("maxDistance:" + (-Camera.main.transform.position + targetFacePosition.position).magnitude);

        foreach (RaycastHit h in hits)
        {
            if (h.collider == col)
            {
                passThroughTargetCollider = true;
                Debug.Log("IM herer");
            }
        }

        if (passThroughTargetCollider != showingBack)
        {
            showingBack = passThroughTargetCollider;
            if (showingBack)
            {
                cardFront.gameObject.SetActive(false);
                cardBack.gameObject.SetActive(true);
            }
            else
            {
                cardFront.gameObject.SetActive(true);
                cardBack.gameObject.SetActive(false);
            }
        }


	}
}
