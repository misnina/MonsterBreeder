using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseTesting : MonoBehaviour
{

    private Monster monster1;
    private Monster monster2;
    public Transform spawn;

    private string[] names = new string[] {"Cherry", "Blueberry", "Pineapple", "Squash" };


    void Start()
    {
        monster1 = new Monster("Cherry", "Square", 5, "Pink", "Pointed", "Pink", "Short", "Pink", "None");
        monster1.SetParents(monster1, Premade.i.golden);
        
        monster2 = new Monster("Blueberry", "Oblong", 3, "Green", "Folded", "Green", "Medium", "Blue", "Stripped");
        monster2.SetParents(monster2, Premade.i.brown);
       


    }

    private void OnMouseDown()
    {
        Monster monster3 = Breeding.instance.Breed("unnamed", monster1, monster2);


        int rand = Random.Range(0, names.Length);
        monster3.MonName = names[rand];

        Debug.Log("Name: " + monster3.MonName + ", Color: " + monster3.Color + ", Type: " + monster3.Type + ", Health: " + monster3.Health);

        GameObject newMonster = Instantiate(DisplayMaster.instance.prefabDict[monster3.Type], spawn.position, Quaternion.identity);
        spawn.position = new Vector2(spawn.position.x + 1f, spawn.position.y);
        newMonster.GetComponent<Display>().monster = monster3;
        newMonster.name = monster3.MonName;



    }
}
