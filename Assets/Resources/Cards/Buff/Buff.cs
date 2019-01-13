using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Buff", menuName = "Buff")]

public class Buff : ScriptableObject
{
    //buff or debuff
    public enum TypeOfBuff
    {
        BUFF = 0,
        DEBUFF = 1
    }

    //buff element type
    public enum TypeOfElement
    {
        NONE = 0,
        FIRE = 1,
        THUNDER = 2,
        WATER = 3,
        WIND = 4
    }

    //takes effect in initial or end of round
    public enum InitialOrEndOfRound
    {
        INITIAL=0,
        END=1
    }

    //name of buff
    public new string name = "";

    //description of buff
    public string description = "";

    //damage per round
    public int damagePerRound = 0;

    //lasting for X rounds
    public int roundNumber = 0;

    //amplify damage for specific element type of spell
    public int amplifyDamagePercentage = 0;
    
    
    public TypeOfBuff typeOfBuff = TypeOfBuff.BUFF;
    public TypeOfElement typeOfElement = TypeOfElement.NONE;
    public InitialOrEndOfRound initialOrEndOfRound = InitialOrEndOfRound.INITIAL;
    
}
