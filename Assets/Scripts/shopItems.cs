using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopItems : MonoBehaviour
{
    public enum ItemTypes
    { //Enumerating all of my shops items   
        BootsNone,
        Boots_1,
        Boots_2,
        Boots_3,

        ShirtNone,
        Shirt_1,
        Shirt_2,
        Shirt_3,
      
        HatNone,
        Hat_1,
        Hat_2,
        Hat_3
    }
    public static int GetCost(ItemTypes itemTypes)
    { //Correlates each item to a price
        switch (itemTypes)
        {
            default:
            case ItemTypes.BootsNone: return 0;
            case ItemTypes.Boots_1: return 50;
            case ItemTypes.Boots_2: return 150;
            case ItemTypes.Boots_3: return 250;

            case ItemTypes.ShirtNone: return 0;
            case ItemTypes.Shirt_1: return 25;
            case ItemTypes.Shirt_2: return 100;
            case ItemTypes.Shirt_3: return 200;
            
            case ItemTypes.HatNone: return 0;
            case ItemTypes.Hat_1: return 100;
            case ItemTypes.Hat_2: return 200;
            case ItemTypes.Hat_3: return 325;



        }
    }
    public static Sprite GetSprite(ItemTypes itemTypes)
    { //Correlates each item to a icon sprite in the shop
        switch (itemTypes)
        {
            default:
            case ItemTypes.BootsNone: return gameAssets.i.BootsNone;
            case ItemTypes.Boots_1: return gameAssets.i.Boots_1;
            case ItemTypes.Boots_2: return gameAssets.i.Boots_2;
            case ItemTypes.Boots_3: return gameAssets.i.Boots_3;

            case ItemTypes.ShirtNone: return gameAssets.i.ShirtNone;
            case ItemTypes.Shirt_1: return gameAssets.i.Shirt_1;
            case ItemTypes.Shirt_2: return gameAssets.i.Shirt_2;
            case ItemTypes.Shirt_3: return gameAssets.i.Shirt_3;
            
            case ItemTypes.HatNone: return gameAssets.i.HatNone;
            case ItemTypes.Hat_1: return gameAssets.i.Hat_1;
            case ItemTypes.Hat_2: return gameAssets.i.Hat_2;
            case ItemTypes.Hat_3: return gameAssets.i.Hat_3;

        }

    }
    public static int GetItemCode(ItemTypes itemTypes){
        switch (itemTypes)
        {
            default:
            case ItemTypes.BootsNone: return 0;
            case ItemTypes.Boots_1: return 1;
            case ItemTypes.Boots_2: return 2;
            case ItemTypes.Boots_3: return 3;

            case ItemTypes.ShirtNone: return 0;
            case ItemTypes.Shirt_1: return 4;
            case ItemTypes.Shirt_2: return 5;
            case ItemTypes.Shirt_3: return 6;
            
            case ItemTypes.HatNone: return 0;
            case ItemTypes.Hat_1: return 7;
            case ItemTypes.Hat_2: return 8;
            case ItemTypes.Hat_3: return 9;



        }
    }
}
