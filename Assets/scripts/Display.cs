using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display : MonoBehaviour
{
  
    public Sprite Circle;
    public Sprite Oblong;
    public Sprite Square;

    public Monster monster;

    private SpriteRenderer sp;

    void Awake()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        GetShape();
    }

    private void GetShape()
    {
        if (monster.Type == "Circle")
        {
            sp.sprite = Circle;

        } else if (monster.Type == "Oblong")
        {
            sp.sprite = Oblong;
        } else if (monster.Type == "Square")
        {
            sp.sprite = Square;
        }
    }

}
