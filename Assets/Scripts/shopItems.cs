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
            case ItemTypes.ShirtNone: return gameAssets.instance.ShirtNone;
            case ItemTypes.Shirt_1: return gameAssets.instance.Shirt_1;
            case ItemTypes.Shirt_2: return gameAssets.instance.Shirt_2;
            case ItemTypes.BootsNone: return gameAssets.instance.BootsNone;
            case ItemTypes.Boots_1: return gameAssets.instance.Boots_1;
            case ItemTypes.Boots_2: return gameAssets.instance.Boots_2;
            case ItemTypes.HatNone: return gameAssets.instance.HatNone;
            case ItemTypes.Hat_1: return gameAssets.instance.Hat_1;
            case ItemTypes.Hat_2: return gameAssets.instance.Hat_2;  

        }

    }
}
