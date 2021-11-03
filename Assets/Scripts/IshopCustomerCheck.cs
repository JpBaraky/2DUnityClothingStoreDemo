using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IshopCustomerCheck //This is an Interface, it usually starts with a I
{
    // Start is called before the first frame update
    void BougthItem(shopItems.ItemTypes itemTypes);

    void SellItem(shopItems.ItemTypes itemTypes);
    bool TrySpendGold(int goldAmount);
    bool TrySellItem(int goldAmount);
    
    

    
}
