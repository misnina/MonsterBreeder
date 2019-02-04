using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Monster
{
    //Main
    public string MonName = "Alice";
    public string Type = "Circle";
    public int Health = 5;
    public string Color = "Brown";

    //Attributes
    public string Ears = "Pointed";
    public string EarsColor = "Brown";
    public string Tail = "Short";
    public string TailColor = "Brown";
    public string TailDetail = "None";

    //Parents
    public Monster Parent1;
    public Monster Parent2;

    public Monster(string monName, string type, int health, string color, string ears, string earsColor, string tail, string tailColor, string tailDetail)
    {
        MonName = monName;
        Type = type;
        Health = health;
        Color = color;
        Ears = ears;
        EarsColor = earsColor;
        Tail = tail;
        TailColor = tailColor;
        TailDetail = tailDetail;
    }

    public void SetParents(Monster parent1, Monster parent2)
    {
        Parent1 = parent1;
        Parent2 = parent2;
    }

}
