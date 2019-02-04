using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MonsterInfo
{
    public int ID;
    public Monster Monster;
    public bool Active;

    public MonsterInfo(int id, Monster monster, bool active)
    {
        ID = id;
        Monster = monster;
        Active = active;
    }

}
