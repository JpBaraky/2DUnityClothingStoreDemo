using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gameAssets : MonoBehaviour
{
    private static gameAssets _i;


    public static gameAssets i
    {
        get
        {
            if (_i == null) _i = Instantiate(Resources.Load<gameAssets>("gameAssets"));
            return _i;
        }
    }
    [Header("List of Items in the Store")]
    //## All sprites inside a Object
    public Sprite ShirtNone;
    public Sprite Shirt_1;
    public Sprite Shirt_2;
    public Sprite Shirt_3;
    public Sprite BootsNone;
    public Sprite Boots_1;
    public Sprite Boots_2;
    public Sprite Boots_3;
    public Sprite HatNone;
    public Sprite Hat_1;
    public Sprite Hat_2;
    public Sprite Hat_3;
    //##
}
