using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class BuffDisplay : MonoBehaviour
{

    public Buff buff;

    public Text buffNameText;
    public Text buffDescriptionText;

    void Start()
    {
        
        if (buff != null)
        {
            
            buffNameText.text = buff.name;
            SetDescription();
        }
        else
        {

        }
    }

    void SetDescription()
    {
        buffDescriptionText.text = "";
        
        if (buff.typeOfBuff == Buff.TypeOfBuff.DEBUFF)
        {
            
            //takes effect in the initial of enemy's round
            if (buff.initialOrEndOfRound == Buff.InitialOrEndOfRound.INITIAL)
            {
                buffDescriptionText.text += "In the <b><color=cyan>initial</color></b> of enemy's round, ";
            }
            //takes effect in the end of enemy's round
            else
            {
                buffDescriptionText.text += "In the <b><color=cyan>end</color></b> of enemy's round, ";
            }

            //takes X damage
            if (buff.damagePerRound != 0)
            {
                switch (buff.typeOfElement)
                {
                    case Buff.TypeOfElement.NONE:
                        buffDescriptionText.text += "deal " + "<b><color=grey>" + buff.damagePerRound + "</color></b>" + " damage, ";
                        break;
                    case Buff.TypeOfElement.FIRE:
                        buffDescriptionText.text += "deal " + "<b><color=#cd2626>" + buff.damagePerRound + "</color></b>" + " damage, ";
                        break;
                    case Buff.TypeOfElement.THUNDER:
                        buffDescriptionText.text += "deal " + "<b><color=#ffff00>" + buff.damagePerRound + "</color></b>" + " damage, ";
                        break;
                    case Buff.TypeOfElement.WATER:
                        buffDescriptionText.text += "deal " + "<b><color=#87cefa>" + buff.damagePerRound + "</color></b>" + " damage, ";
                        break;
                    case Buff.TypeOfElement.WIND:
                        buffDescriptionText.text += "deal " + "<b><color=#76eec6>" + buff.damagePerRound + "</color></b>" + " damage, ";
                        break;

                }
                if (buff.roundNumber != 0)
                {
                    buffDescriptionText.text += "effect will last " + "<b>" + buff.roundNumber + "</b>" + " rounds.";
                }
            }


        }
    }
}
