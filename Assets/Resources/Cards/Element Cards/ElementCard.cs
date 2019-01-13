using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Element Card",menuName ="Cards/Element Card")]
public class ElementCard : ScriptableObject {

    
    //card name
    public new string name;
    //card description
    public string description;
    //card image
    public Sprite cardImage;


    //debug purpose,show the information of the card
    public void print()
    {
        Debug.Log("name:" + name + "/description:" + description);
    }

}
