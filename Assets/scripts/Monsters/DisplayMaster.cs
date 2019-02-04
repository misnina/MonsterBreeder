using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayMaster : MonoBehaviour
{

    public static DisplayMaster instance;
    public IDictionary<string, GameObject> prefabDict = new Dictionary<string, GameObject>();
    public IDictionary<string, Sprite> typeDict = new Dictionary<string, Sprite>();
    public IDictionary<string, Color> colorDict = new Dictionary<string, Color>();
    public IDictionary<string, Sprite> earDict = new Dictionary<string, Sprite>();
    public IDictionary<string, Sprite> tailTypeDict = new Dictionary<string, Sprite>();
    public IDictionary<string, Sprite> tailDetailDict = new Dictionary<string, Sprite>();

    //Type Prefabs
    public GameObject circle;
    public GameObject oblong;
    public GameObject square;

    public Sprite none;

    //Type Sprites
    public Sprite circleSprite;
    public Sprite oblongSprite;
    public Sprite squareSprite;

    //Color Entries
    public Color brown;
    public Color gold;
    public Color white;
    public Color grey;
    public Color black;
    public Color yellow;
    public Color orange;
    public Color red;
    public Color pink;
    public Color violet;
    public Color blue;
    public Color green;

    //Ear Types
    public Sprite earsPointed;
    public Sprite earsFolded;

    //Tail Types
    public Sprite tailLong;
    public Sprite tailMedium;
    public Sprite tailShort;

    //Tail Details
    public Sprite tailLongStripped;
    public Sprite tailMediumStripped;
    public Sprite tailShortStripped;


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

        //Color Dictionary Instance
        colorDict.Add("Brown", brown);
        colorDict.Add("Gold", gold);
        colorDict.Add("White", white);
        colorDict.Add("Grey", grey);
        colorDict.Add("Black", black);
        colorDict.Add("Yellow", yellow);
        colorDict.Add("Orange", orange);
        colorDict.Add("Red", red);
        colorDict.Add("Pink", pink);
        colorDict.Add("Violet", violet);
        colorDict.Add("Blue", blue);
        colorDict.Add("Green", green);

        //Attributes Dictionary Instances
        //Ear Types
        earDict.Add("Pointed", earsPointed);
        earDict.Add("Folded", earsFolded);

        //Tail Types
        tailTypeDict.Add("Long", tailLong);
        tailTypeDict.Add("Medium", tailMedium);
        tailTypeDict.Add("Short", tailShort);

        //Tail Details
        tailDetailDict.Add("Stripped Long", tailLongStripped);
        tailDetailDict.Add("Stripped Medium", tailMediumStripped);
        tailDetailDict.Add("Stripped Short", tailShortStripped);

    }
}
