using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject selected01;
    public GameObject selected02;

    public Monster selectedParent0101, selectedParent0102, selectedParent0201, selectedParent0202;
    public GameObject selectedDisplay01, selectedDisplay02, selectedDisplay03, selectedDisplay04;

    public IDictionary<int, MonsterInfo> monsterDict = new Dictionary<int, MonsterInfo>();
    public int allMonsterCount;

    private void Awake()
    {
        instance = this;
    }

     private void Update()
    {
        if(selected01)
        {
            selectedParent0101 = selected01.transform.parent.GetComponent<Display>().monster.Parent1;
            selectedParent0102 = selected01.transform.parent.GetComponent<Display>().monster.Parent2;

            selectedDisplay01.GetComponent<Display>().monster = selectedParent0101;
            selectedDisplay01.GetComponent<Display>().DisplaySprite();
            selectedDisplay02.GetComponent<Display>().monster = selectedParent0102;
            selectedDisplay02.GetComponent<Display>().DisplaySprite();
        }
        if (selected02)
        {
            selectedParent0201 = selected02.transform.parent.GetComponent<Display>().monster.Parent1;
            selectedParent0202 = selected02.transform.parent.GetComponent<Display>().monster.Parent2;

            selectedDisplay03.GetComponent<Display>().monster = selectedParent0201;
            selectedDisplay03.GetComponent<Display>().DisplaySprite();
            selectedDisplay04.GetComponent<Display>().monster = selectedParent0202;
            selectedDisplay04.GetComponent<Display>().DisplaySprite();

        }


    }
    
}
