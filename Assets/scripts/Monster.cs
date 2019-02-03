using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Monster
{
    public string MonName = "Default";
    public string Type = "Circle";
    public int Health = 5;
    public string Color = "Brown";
    //Attributes
    public string Ears = "Pointed";


    public Monster Parent1;
    public Monster Parent2;

    public void GetMain(string monName, string type, int health, string color)
    {
        MonName = monName;
        Type = type;
        Health = health;
        Color = color;

    }

    public void GetParents(Monster parent1, Monster parent2)
    {
        Parent1 = parent1;
        Parent2 = parent2;
    }

    public void GetAttributes(string ears)
    {
        Ears = ears;
    }

}
