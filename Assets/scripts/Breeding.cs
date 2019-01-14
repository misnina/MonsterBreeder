using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breeding : MonoBehaviour
{

    public static Breeding instance;

    private Monster Parent1;
    private Monster Parent2;


    private void Start()
    {
        instance = this;
    }


    private int GetHealth()
    {
        return Random.Range(Parent1.Health, Parent2.Health) + 1;
    }

    private string GetColor()
    {
        if (Random.value < 0.5f)
        {
            if(Random.value < 0.5f)
            {
                return Parent1.Color;
            }
            else
            {
                if(Random.value < 0.5f)
                {
                    return Parent1.Parent1Color;
                }
                else
                {
                    return Parent1.Parent2Color;
                }
            }
        }
        else
        {
            if (Random.value < 0.5f)
            {
                return Parent2.Color;
            }
            else
            {
                if (Random.value < 0.5f)
                {
                    return Parent2.Parent1Color;
                }
                else
                {
                    return Parent2.Parent2Color;
                }
            }
        }
    }

    private string GetMonType()
    {
        if (Random.value < 0.5f)
        {
            if (Random.value < 0.5f)
            {
                return Parent1.Type;
            }
            else
            {

                if (Random.value < 0.5f)
                {
                    return Parent1.Parent1Type;
                }
                else
                {
                    return Parent1.Parent2Type;
                }
            }
        }
        else
        {
            if (Random.value < 0.5f)
            {
                return Parent2.Type;
            }
            else
            {

                if (Random.value < 0.5f)
                {
                    return Parent2.Parent1Type;
                }
                else
                {
                    return Parent2.Parent2Type;
                }
            }
        }
    }


    public Monster Breed(string monName, Monster parent1, Monster parent2)
    {
        Parent1 = parent1;
        Parent2 = parent2;

        return new Monster(monName, GetMonType(), GetHealth(), GetColor(), Parent1.Type, Parent2.Type, Parent1.Color, Parent2.Color);

    }
    


}
