using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Buff", menuName = "Buff")]

public class Buff : ScriptableObject
{
    public enum TypeOfBuff
    {
        BUFF = 0,
        DEBUFF = 1
    }

    public enum TypeOfElement
    {
        NONE = 0,
        FIRE = 1,
        THUNDER = 2,
        WATER = 3,
        WIND = 4
    }

    public new string name = "";

    public string description = "";

    public int damage = 0;

    public int roundNumber = 0;

    public TypeOfBuff typeOfBuff = TypeOfBuff.BUFF;
    public TypeOfElement typeOfElement = TypeOfElement.NONE;
}
