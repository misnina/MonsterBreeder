using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBreeding : MonoBehaviour
{
    public static MonsterBreeding instance;
    public Monster breeding1;
    public Monster breeding2;

    private void Start()
    {
        instance = this;
    }

    public Monster Breed(string monName, Monster parent1, Monster parent2)
    {
        breeding1 = parent1;
        breeding2 = parent2;


        Monster child = new Monster();
        child.GetParents(breeding1, breeding2);
        child.GetAttributes(monName, GetMonType(), GetHealth(), GetColor());

        return child;
    }

    private string GetMonType()
    {
        switch (Genetics())
        {
            case 1: return breeding1.Type; 
            case 2: return breeding2.Type; 
            case 3: return breeding1.Parent1.Type; 
            case 4: return breeding1.Parent2.Type; 
            case 5: return breeding2.Parent1.Type; 
            case 6: return breeding2.Parent1.Type;
            default: return"error"; 
        }
    }

    private int GetHealth()
    {
        return Random.Range(breeding1.Health, breeding2.Health) + 1;
    }

    private string GetColor()
    {
        switch(Genetics())
        {
            case 1: return breeding1.Color; 
            case 2: return breeding2.Color; 
            case 3: return breeding1.Parent1.Color; 
            case 4: return breeding1.Parent2.Color; 
            case 5: return breeding2.Parent1.Color; 
            case 6: return breeding2.Parent1.Color;
            default: return "error"; 
        }
    }

    //50% split between parent's attributes, then 50% split between grandparent attributes
    private int Genetics()
    {
        {
            if (Random.value < 0.5f)
            {
                if (Random.value < 0.5f)
                {
                    return 1;
                }
                else
                {
                    if (Random.value < 0.5f)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
            else
            {
                if (Random.value < 0.5f)
                {
                    return 2;
                }
                else
                {
                    if (Random.value < 0.5f)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }

}
