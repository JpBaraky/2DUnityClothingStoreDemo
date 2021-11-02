using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopItems : MonoBehaviour
{
    public enum ItemTypes{ //Enumerating all of my shops items 
        ShirtNone,
        Shirt_1,
        Shirt_2,
        BootsNone,
        Boots_1,
        Boots_2,
        HatNone,
        Hat_1,
        Hat_2
    }
    public static int GetCost( ItemTypes itemTypes ){ //Correlates each item to a price
        switch(itemTypes){
            default:
            case ItemTypes.ShirtNone: return 0;
            case ItemTypes.Shirt_1: return 25;
            case ItemTypes.Shirt_2: return 100;
            case ItemTypes.BootsNone: return 0;
            case ItemTypes.Boots_1: return 50;
            case ItemTypes.Boots_2: return 150;
            case ItemTypes.HatNone: return 0;
            case ItemTypes.Hat_1: return 30;
            case ItemTypes.Hat_2: return 90;           
            

        }
    }
        public static Sprite GetSprite( ItemTypes itemTypes){ //Correlates each item to a icon sprite in the shop
        switch(itemTypes){
            default:
            case ItemTypes.ShirtNone: return GameAssets.i.ShirtNone;
            case ItemTypes.Shirt_1: return GameAssets.i.Shirt_1;
            case ItemTypes.Shirt_2: return GameAssets.i.Shirt_2;
            case ItemTypes.BootsNone: return GameAssets.i.BootsNone;
            case ItemTypes.Boots_1: return GameAssets.i.Boots_1;
            case ItemTypes.Boots_2: return GameAssets.i.Boots_2;
            case ItemTypes.HatNone: return GameAssets.i.HatNone;
            case ItemTypes.Hat_1: return GameAssets.i.Hat_1;
            case ItemTypes.Hat_2: return GameAssets.i.Hat_2;  

        }

    }
}
