using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Spell Card", menuName = "Cards/Spell Card")]
public class SpellCard : ElementCard
{
    public enum TypeOfElement
    {
        NONE = 0,
        FIRE = 1,
        THUNDER = 2,
        WATER = 3,
        WIND = 4
    }

    public int attackValue;

    public Sprite[] ribbons;

    public TypeOfElement typeOfElement = TypeOfElement.NONE;


    public new void print()
    {
        Debug.Log("name:" + name + "/description:" + description + "/Attack Value:" + attackValue);
    }

}
