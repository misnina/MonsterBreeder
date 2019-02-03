using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breeding : MonoBehaviour
{
    public static Breeding instance;
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
        child.GetMain(monName, GetMonType(), GetHealth(), GetColor());
        child.GetAttributes(GetEars(), GetEarsColor(), GetTail(), GetTailColor(), GetTailDetail());

        return child;
    }

    //Main Characteristics
    private string GetMonType()
    {
        switch (Genetics(0.5f))
        {
            case 1: return breeding1.Type; 
            case 2: return breeding2.Type; 
            case 3: return breeding1.Parent1.Type; 
            case 4: return breeding1.Parent2.Type; 
            case 5: return breeding2.Parent1.Type; 
            case 6: return breeding2.Parent2.Type;
            default: return"error"; 
        }
    }

    private int GetHealth()
    {
        return Random.Range(breeding1.Health, breeding2.Health) + 1;
    }

    private string GetColor()
    {
        switch(Genetics(0.75f))
        {
            case 1: return breeding1.Color; 
            case 2: return breeding2.Color; 
            case 3: return breeding1.Parent1.Color; 
            case 4: return breeding1.Parent2.Color; 
            case 5: return breeding2.Parent1.Color; 
            case 6: return breeding2.Parent2.Color;
            default: return "error"; 
        }
    }

    //Attributes
    private string GetEars()
    {
        switch (Genetics(0.25f))
        {
            case 1: return breeding1.Ears;
            case 2: return breeding2.Ears;
            case 3: return breeding1.Parent1.Ears;
            case 4: return breeding1.Parent2.Ears;
            case 5: return breeding2.Parent1.Ears;
            case 6: return breeding2.Parent2.Ears;
            default: return "error";
        }
    }

    private string GetEarsColor()
    {
        switch (Genetics(0.75f))
        {
            case 1: return breeding1.EarsColor;
            case 2: return breeding2.EarsColor;
            case 3: return breeding1.Parent1.EarsColor;
            case 4: return breeding1.Parent2.EarsColor;
            case 5: return breeding2.Parent1.EarsColor;
            case 6: return breeding2.Parent2.EarsColor;
            default: return "error";
        }
    }

    private string GetTail()
    {
        switch (Genetics(0.25f))
        {
            case 1: return breeding1.Tail;
            case 2: return breeding2.Tail;
            case 3: return breeding1.Parent1.Tail;
            case 4: return breeding1.Parent2.Tail;
            case 5: return breeding2.Parent1.Tail;
            case 6: return breeding2.Parent2.Tail;
            default: return "error";
        }
    }

    private string GetTailColor()
    {
        switch (Genetics(0.75f))
        {
            case 1: return breeding1.TailColor;
            case 2: return breeding2.TailColor;
            case 3: return breeding1.Parent1.TailColor;
            case 4: return breeding1.Parent2.TailColor;
            case 5: return breeding2.Parent1.TailColor;
            case 6: return breeding2.Parent2.TailColor;
            default: return "error";
        }
    }

    private string GetTailDetail ()
    {
        switch (Genetics(0.25f))
        {
            case 1: return breeding1.TailDetail;
            case 2: return breeding2.TailDetail;
            case 3: return breeding1.Parent1.TailDetail;
            case 4: return breeding1.Parent2.TailDetail;
            case 5: return breeding2.Parent1.TailDetail;
            case 6: return breeding2.Parent2.TailDetail;
            default: return "error";
        }
    }

    private int Genetics(float Weight)
    {
        
        if (Random.value <= Weight)
        {
            if (Random.value < 0.75f)
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
            if (Random.value < 0.75f)
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
