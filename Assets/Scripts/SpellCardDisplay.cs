using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]

public class SpellCardDisplay : MonoBehaviour
{

    public SpellCard spellCard;

    public Text nameText;
    public Text descriptionText;
    public Text attacktValueText;

    public Image cardNameImage;

    public Image cardImage;

    // Use this for initialization
    void Start()
    {

        spellCard.print();

        nameText.text = spellCard.name;
        descriptionText.text = spellCard.description;
        attacktValueText.text = spellCard.attackValue.ToString();

        cardImage.sprite = spellCard.cardImage;
        
        if (cardNameImage == null)
        {
            Debug.Log("cardnameimage is null");
        }
        if (spellCard.ribbons == null)
        {
            Debug.Log("ribbons is null");
        }
        cardNameImage.sprite = spellCard.ribbons[(int)spellCard.typeOfElement];


    }

}
