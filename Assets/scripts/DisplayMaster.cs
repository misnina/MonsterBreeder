using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayMaster : MonoBehaviour
{

   public static DisplayMaster instance;
   public IDictionary<string, GameObject> prefabDict = new Dictionary<string, GameObject>();
   public IDictionary<string, Sprite> typeDict = new Dictionary<string, Sprite>();
   public IDictionary<string, Sprite> earDict = new Dictionary<string, Sprite>();

    //Type Prefabs
    public GameObject circle;
    public GameObject oblong;
    public GameObject square;

    //Type Sprites
    public Sprite circleSprite;
    public Sprite oblongSprite;
    public Sprite squareSprite;

    //Ear Types
    public Sprite earsPointed;
    public Sprite earsFolded;


    private void Awake()
    {
        instance = this;

        //Prefab Dictionary Instances
        prefabDict.Add("Circle", circle);
        prefabDict.Add("Oblong", oblong);
        prefabDict.Add("Square", square);


        //Type Dictionary Instances
        typeDict.Add("Circle", circleSprite);
        typeDict.Add("Oblong", oblongSprite);
        typeDict.Add("Square", squareSprite);

        //Attributes Dictionary Instances
        //Ear Types
        earDict.Add("Pointed", earsPointed);
        earDict.Add("Folded", earsFolded);

    }
}
