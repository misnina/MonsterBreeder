using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{
    private bool selected;
    private bool becameOne;
    private bool becameTwo;

    private SpriteRenderer sp;

    private void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1)) {
            Destroy(this.transform.parent.transform.gameObject);
            UseTesting.instance.spawnCount--;
        }
    }

    private void OnMouseDown()
    {
        if (!selected)
        {
            if (GameManager.instance.selected01 == null)
            {
                sp.enabled = true;
                GameManager.instance.selected01 = this.gameObject;
                selected = true;
                becameOne = true;
            }
            else if (GameManager.instance.selected02 == null)
            {
                sp.enabled = true;
                GameManager.instance.selected02 = this.gameObject;
                selected = true;
                becameTwo = true;
            } else
            {
                sp.enabled = true;
                GameManager.instance.selected01.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                GameManager.instance.selected01.gameObject.GetComponent<Selector>().selected = false;
                GameManager.instance.selected01.gameObject.GetComponent<Selector>().becameOne = false;
                GameManager.instance.selected01 = null;
                GameManager.instance.selected01 = this.gameObject;
                selected = true;
                becameOne = true;
            }
        }
        else //if already selected
        {
            if (becameOne)
            {
                sp.enabled = false;
                selected = false;
                GameManager.instance.selected01.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                GameManager.instance.selected01.gameObject.GetComponent<Selector>().selected = false;
                GameManager.instance.selected01.gameObject.GetComponent<Selector>().becameOne = false;
                GameManager.instance.selected01 = null;
            }
            else if (becameTwo)
            {
                sp.enabled = false;
                selected = false;
                GameManager.instance.selected02.gameObject.GetComponent<Selector>().selected = false;
                GameManager.instance.selected02.gameObject.GetComponent<Selector>().becameTwo = false;
                GameManager.instance.selected02.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                GameManager.instance.selected02 = null;
            }
        }
    }
}
