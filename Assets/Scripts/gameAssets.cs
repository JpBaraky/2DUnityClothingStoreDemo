using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameAssets : MonoBehaviour
{
    private static gameAssets i;
    public static gameAssets instance{
        get{
            if (i == null)
            {i = (Instantiate(Resources.Load("gameAssets")) as GameObject).GetComponent<gameAssets>();} //If the internal value is null, as in the first time it runs, instatiate the assets as game objects
        return i;
        }
    }

//## All sprites inside a Object
    public Sprite ShirtNone;
    public Sprite Shirt_1;
    public Sprite Shirt_2;
    public Sprite BootsNone;
    public Sprite Boots_1;
    public Sprite Boots_2;
    public Sprite HatNone;
    public Sprite Hat_1;
    public Sprite Hat_2;
//##
}
