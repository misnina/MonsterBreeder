using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTabDisplay : MonoBehaviour
{
    public static MonsterTabDisplay instance;
    public GameObject container;

    public int width = 4;
    public int height = 6;

    private void Start()
    {
        instance = this;
        //RenderDisplayOrder();
    }

    public void RenderDisplayOrder()
    {
        //Destroy Previous Render
        Transform[] allChildren = new Transform[container.transform.childCount];
        for(int i = 0; i < container.transform.childCount; i++)
        {
            allChildren[i] = container.transform.GetChild(i).GetComponent<Transform>();
        }
    
        foreach (Transform child in allChildren)
        {
            Destroy(child.gameObject);
        }

        //Create a Queue of all monsters
        Queue<GameObject> AllMonsters = new Queue<GameObject>();

        foreach (var ID in GameManager.instance.monsterDict)
        {
            MonsterInfo monsterInfo = GameManager.instance.monsterDict[ID.Key];
            if (monsterInfo.Active)
            {

                GameObject monster = Instantiate(DisplayMaster.instance.prefabDict[monsterInfo.Monster.Type], Vector2.zero, Quaternion.identity, container.transform);
                monster.name = monsterInfo.Monster.ID.ToString();
                monster.GetComponent<Display>().monster = monsterInfo.Monster;
                AllMonsters.Enqueue(monster);


            }
            else
            {
                Debug.Log("Monster has been deleted");
            }
        }

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                AllMonsters.Peek().transform.position = new Vector3(container.transform.position.x + x, container.transform.position.y - y, transform.position.z);
                AllMonsters.Dequeue();
            }
        }
    }
}
