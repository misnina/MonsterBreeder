using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseTesting : MonoBehaviour
{

    private Monster monster1;
    private Monster monster2;

    public GameObject monster;
    public Transform spawn;

    private string[] names = new string[] {"Cherry", "Blueberry", "Pineapple", "Squash" };


    void Start()
    {
        monster1 = new Monster("Apple", "Circle", 25, "green", " Circle", "Square", "pink", "green");
        monster2 = new Monster("Pear", "Oblong", 20, "green", "Oblong", "Circle", "brown", "green");

    }

    private void OnMouseDown()
    {
        Monster monster3 = Breeding.instance.Breed("unnamed", monster1, monster2);

        int rand = Random.Range(0, names.Length);
        monster3.MonName = names[rand];

        Debug.Log("Name: " + monster3.MonName + ", Color: " + monster3.Color + ", Type: " + monster3.Type + ", Health: " + monster3.Health);

        GameObject newMonster = Instantiate(monster, spawn.position, Quaternion.identity);
        newMonster.GetComponent<Display>().monster = monster3;



    }
}
