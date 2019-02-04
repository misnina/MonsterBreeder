using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTabDisplay : MonoBehaviour
{
    public static MonsterTabDisplay instance;
    public GameObject container;

    private void Start()
    {
        instance = this;
        RenderDisplayOrder();
    }

    public void RenderDisplayOrder()
    {
        foreach(var ID in GameManager.instance.monsterDict) {
            if(GameManager.instance.monsterDict[ID.Key].Active)
            {
                //Display Monsters
                //Broken until I can figure out how to order things myself

            }
            else
            {
                Debug.Log("Monster has been deleted");
            }
        }
    }
}
