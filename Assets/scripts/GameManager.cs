using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject selected01;
    public GameObject selected02;

    private void Awake()
    {
        instance = this;
    }
}
