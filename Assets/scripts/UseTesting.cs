using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseTesting : MonoBehaviour
{
    public Transform spawn;

    private Monster monster1;
    private Monster monster2;
    private Vector2 startSpawn;
    public int spawnCount;

    public static UseTesting instance;

    private string[] names = new string[] {"Cherry", "Blueberry", "Pineapple", "Squash" };


    void Start()
    {
        instance = this;
        startSpawn = spawn.position;
        monster1 = new Monster("Cherry", "Square", 5, "Pink", "Pointed", "Pink", "Short", "Pink", "None");
        monster1.SetParents(monster1, Premade.i.golden);
        
        monster2 = new Monster("Blueberry", "Oblong", 3, "Green", "Folded", "Green", "Medium", "Blue", "Stripped");
        monster2.SetParents(monster2, Premade.i.brown);
       


    }

    private void Update()
    {
        RaycastHit2D hitCollider = Physics2D.Raycast(spawn.position, Vector2.zero);

        if (hitCollider)
        {
            MoveSpawnPos();
        }
    }

    private void OnMouseDown()
    {
        if (spawn.position.y > -4.5f && spawnCount < 35)
        {
            Monster monster3;

            if (GameManager.instance.selected02 == null)
            {
                monster3 = Breeding.instance.Breed("unnamed", monster1, monster2);
            }
            else
            {
                Monster gmMonster1 = GameManager.instance.selected01.transform.parent.GetComponent<Display>().monster;
                Monster gmMonster2 = GameManager.instance.selected02.transform.parent.GetComponent<Display>().monster;
                monster3 = Breeding.instance.Breed("unnamed", gmMonster1, gmMonster2);
            }
           

            int rand = Random.Range(0, names.Length);
            monster3.MonName = names[rand];

            Debug.Log("Name: " + monster3.MonName + ", Color: " + monster3.Color + ", Type: " + monster3.Type + ", Health: " + monster3.Health);

            GameObject newMonster = Instantiate(DisplayMaster.instance.prefabDict[monster3.Type], spawn.position, Quaternion.identity);
            spawnCount++;
            MoveSpawnPos();
            newMonster.GetComponent<Display>().monster = monster3;
            newMonster.name = monster3.MonName;

        } else
        {
            spawn.position = startSpawn;
        }

    }

    private void MoveSpawnPos()
    {
        if (spawn.position.x < 2)
        {
            spawn.position = new Vector2(spawn.position.x + 1f, spawn.position.y);
            Debug.Log("Moved Spawn");

        }
        else if (spawn.position.x >= 2)
        {
            Debug.Log("New Row Started");
            spawn.position = new Vector2(-2f, spawn.position.y + -1);

        }
    }
}
