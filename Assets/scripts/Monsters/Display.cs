using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display : MonoBehaviour
{
 
    public Monster monster;
    private SpriteRenderer typesp;
    private SpriteRenderer earssp;
    private SpriteRenderer tailsp;
    private SpriteRenderer taildetailsp;

    private void Start()
    {
        DisplaySprite();
    }

    public void DisplaySprite()
    {
        //Type Display
        typesp = GetComponent<SpriteRenderer>();
        typesp.sprite = DisplayMaster.instance.typeDict[monster.Type];
        typesp.color = DisplayMaster.instance.colorDict[monster.Color];

        //Ear Display
        earssp = this.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
        earssp.sprite = DisplayMaster.instance.earDict[monster.Ears];
        earssp.color = DisplayMaster.instance.colorDict[monster.EarsColor];

        //Tail Display
        tailsp = this.gameObject.transform.GetChild(1).GetComponent<SpriteRenderer>();
        taildetailsp = tailsp.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
        tailsp.sprite = DisplayMaster.instance.tailTypeDict[monster.Tail];
        tailsp.color = DisplayMaster.instance.colorDict[monster.TailColor];
        taildetailsp.color = DisplayMaster.instance.colorDict[monster.TailColor];

        //Picks detail to display based on tail length
        switch (monster.TailDetail)
        {
            case "Stripped":
                switch (monster.Tail)
                {
                    case "Long":
                        taildetailsp.sprite = DisplayMaster.instance.tailDetailDict["Stripped Long"];
                        break;
                    case "Medium":
                        taildetailsp.sprite = DisplayMaster.instance.tailDetailDict["Stripped Medium"];
                        break;
                    case "Short":
                        taildetailsp.sprite = DisplayMaster.instance.tailDetailDict["Stripped Short"];
                        break;
                }
                break;

            case "None":
                Debug.Log("No tail detail");
                break;

            default:
                Debug.Log("No tail detail");
                break;
        }

    }

}
