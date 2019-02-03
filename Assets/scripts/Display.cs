using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display : MonoBehaviour
{
 
    public Monster monster;
    private SpriteRenderer typesp;
    private SpriteRenderer earssp;

    private void Start()
    {
        //Type Display
        typesp = GetComponent<SpriteRenderer>();
        typesp.sprite = DisplayMaster.instance.typeDict[monster.Type];

        //Ear Display
        earssp = this.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
        earssp.sprite = DisplayMaster.instance.earDict[monster.Ears];

    }

}
