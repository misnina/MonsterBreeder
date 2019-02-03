using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Premade : MonoBehaviour
{

    public static Premade i;

    public Monster golden;
    public Monster brown;

    private void Awake()
    {
        i = this;

        golden.GetMain("Shiny", "Circle", 10, "Gold");
        golden.GetAttributes("Folded", "Gold", "Long", "Gold", "Stripped");
        golden.GetParents(golden, golden);

        brown.GetMain("Marco", "Square", 5, "Brown");
        brown.GetAttributes("Pointed", "Brown", "Medium", "Brown", "None");
        brown.GetParents(brown, brown);


    }
}
