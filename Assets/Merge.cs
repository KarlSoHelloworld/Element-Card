using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Merge : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    //Canvas object
    public Transform canvas;

    //PlayerTableTop Object
    public Transform playerTableTop;

    //variables for counting different types of clicked element cards.
    int fireCount = 0;
    int windCount = 0;
    int waterCount = 0;
    int thunderCount = 0;

    //variable for saving the spell card name.
    string spellCardName = "";

    //variable for saving SpellCard instance.
    GameObject spellCard;

    //variable for saving creating or nor creating the spell card in playerTableTop.
    bool createdSpellCard = false;

    //btn click event
    public void OnPointerClick(PointerEventData eventData)
    {
        createdSpellCard = true;
        
        if (spellCard != null)
        {
            //after click the "Merge" btn, move the Spell Card into playerTableTop.
            spellCard.transform.SetParent(playerTableTop);
            spellCard.transform.localScale.Set(0.4f, 0.4f, 0.4f);
            spellCard.GetComponent<SpellCardDisplay>().spellCard = (SpellCard)Instantiate(Resources.Load("Cards/Spell Cards/" + spellCardName));

            //Destroy merged element card.
            GameObject[] clickedCards = GameObject.FindGameObjectsWithTag("ClickedElementCard");

            foreach (GameObject clickObject in clickedCards)
            {
                GameObject.Destroy(clickObject);
            }
        }
    }

    //btn hover event
    public void OnPointerEnter(PointerEventData eventData)
    {
        ResetEnviornment();
        
        //get clicked element card gameobject
        GameObject[] clickedCards = GameObject.FindGameObjectsWithTag("ClickedElementCard");

        if (clickedCards.Length > 0)
        {

            //counting for different types of element.
            foreach (GameObject clickObject in clickedCards)
            {
                ElementCardDisplay clickedElementCard = clickObject.GetComponent<ElementCardDisplay>();

                switch (clickedElementCard.elementCard.name)
                {
                    case "Fire":
                        fireCount++;
                        break;
                    case "Wind":
                        windCount++;
                        break;
                    case "Water":
                        waterCount++;
                        break;
                    case "Thunder":
                        thunderCount++;
                        break;
                }
            }

            spellCardName = WhichSpellCard();

            if (spellCardName != null)
            {
                spellCard = (GameObject)Instantiate(Resources.Load("Prefabs/SpellCard"), Vector3.zero, new Quaternion(0f, 0f, 0f, 0f), canvas);                
                spellCard.GetComponent<SpellCardDisplay>().spellCard = (SpellCard)Instantiate(Resources.Load("Cards/Spell Cards/" + spellCardName));
            }
        }
    }

    //btn exit event
    public void OnPointerExit(PointerEventData eventData)
    {
        if (spellCard != null&& createdSpellCard==false)
        {
            GameObject.Destroy(spellCard);
        }
    }

    //reset the variables for counting different types of clicked element cards& Spell Card infos.
    private void ResetEnviornment()
    {
        fireCount = 0;
        windCount = 0;
        waterCount = 0;
        thunderCount = 0;
        spellCardName = "";
        createdSpellCard = false;
    }

    //checking what kinds of spell card can be merge by using clicked element cards.
    private string WhichSpellCard()
    {
        string spellCardName = "";

        if (fireCount == 1)
        {
            spellCardName = "FireBall";
        }

        if (fireCount == 2)
        {
            spellCardName = "BigFireBall";
        }

        //to be continued...

        return spellCardName;
    }


}
