using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameAssets : MonoBehaviour
{
    private static GameAssets _i;

    public static GameAssets i {
        get {
            if (_i == null) _i = Instantiate(Resources.Load<GameAssets>("GameAssets"));
            return _i;
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
