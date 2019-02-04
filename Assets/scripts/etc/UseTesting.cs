using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseTesting : MonoBehaviour
{
    public Transform spawn;

    private Vector2 startSpawn;
    public int spawnCount;

    public static UseTesting instance;

    private string[] names = new string[] {"Cherry", "Blueberry", "Pineapple", "Squash" };


    void Start()
    {
        instance = this;
        startSpawn = spawn.position;
       
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
            Monster monster;

            if (GameManager.instance.selected01 == null &&GameManager.instance.selected02 == null)
            {
                int rand1 = Random.Range(0, Premade.i.randMonsterDict.Count);
                int rand2 = Random.Range(0, Premade.i.randMonsterDict.Count);
                monster = Breeding.instance.Breed("unnamed", Premade.i.randMonsterDict[rand1], Premade.i.randMonsterDict[rand2]);

                if (monster != null)
                {
                    CreateMonster(monster);
                }
            }
            else
            {
                Monster gmMonster1 = GameManager.instance.selected01.transform.parent.GetComponent<Display>().monster;
                Monster gmMonster2 = GameManager.instance.selected02.transform.parent.GetComponent<Display>().monster;
                monster = Breeding.instance.Breed("unnamed", gmMonster1, gmMonster2);

                if (monster != null)
                {
                    CreateMonster(monster);
                }

            } 

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

    private void CreateMonster(Monster monster)
    {
        int rand = Random.Range(0, names.Length);
        monster.MonName = names[rand];

        GameObject newMonster = Instantiate(DisplayMaster.instance.prefabDict[monster.Type], spawn.position, Quaternion.identity);
        spawnCount++;
        MoveSpawnPos();
        newMonster.GetComponent<Display>().monster = monster;
        newMonster.name = monster.MonName;
    }
}
