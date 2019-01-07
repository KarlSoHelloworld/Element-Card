using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]

public class ElementCardDisplay : MonoBehaviour {

    public ElementCard elementCard;

    public Text nameText;
    public Text descriptionText;

    public Image cardImage;
   
	// Use this for initialization
	void Start () {

        //elementCard.print();//for debugging

        nameText.text = elementCard.name;
        descriptionText.text = elementCard.description;

        cardImage.sprite = elementCard.cardImage;
	}
	
}
