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

        golden = new Monster("Shiny", "Circle", 10, "Gold", "Folded", "Gold", "Long", "Gold", "Stripped");
        golden.SetParents(golden, golden);

        brown = new Monster("Marco", "Square", 5, "Brown", "Pointed", "Brown", "Medium", "Brown", "None");
        brown.SetParents(brown, brown);


    }
}
