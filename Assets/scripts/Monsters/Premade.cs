using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Premade : MonoBehaviour
{

    public static Premade i;

    public IDictionary<int, Monster> randMonsterDict = new Dictionary<int, Monster>();
    public Monster golden;
    public Monster brown;
    public Monster pink;
    public Monster aqua;

    private void Awake()
    {
        i = this;

        golden = new Monster(-1, "Shiny", "Circle", 10, "Gold", "Folded", "Gold", "Long", "Gold", "Stripped");
        golden.SetParents(golden, golden);

        brown = new Monster(-2, "Marco", "Square", 5, "Brown", "Pointed", "Brown", "Medium", "Brown", "None");
        brown.SetParents(brown, brown);

        pink = new Monster(-3, "Cherry", "Square", 5, "Pink", "Pointed", "Pink", "Short", "Pink", "None");
        pink.SetParents(pink, Premade.i.golden);

        aqua = new Monster(-4, "Blueberry", "Oblong", 3, "Green", "Folded", "Green", "Medium", "Blue", "Stripped");
        aqua.SetParents(aqua, Premade.i.brown);

        randMonsterDict.Add(0, golden);
        randMonsterDict.Add(1, brown);
        randMonsterDict.Add(2, pink);
        randMonsterDict.Add(3, aqua);


    }
}
