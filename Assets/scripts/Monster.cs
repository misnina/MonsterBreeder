using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Monster
{
    public string MonName;
    public string Type;
    public int Health;
    public string Color;

    public string Parent1Type;
    public string Parent2Type;
    public string Parent1Color;
    public string Parent2Color;

    public Monster(string monName, string type, int health, string color, string parent1Type, string parent2Type, string parent1Color, string parent2Color)
    {
        MonName = monName;
        Type = type;
        Health = health;
        Color = color;
        Parent1Type = parent1Type;
        Parent2Type = parent2Type;
        Parent1Color = parent1Color;
        Parent2Color = parent2Color;

    }

}
