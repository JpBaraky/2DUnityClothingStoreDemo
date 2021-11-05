using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopTriggerCollider : MonoBehaviour

{
    
  [SerializeField] private shopController uiShopBuy; // Recives what is the Ui of the shop
  [SerializeField] private shopController uiShopSell; // Recives what is the Ui of the shop
   void OnTriggerEnter2D( Collider2D collider){ //Checking if anyone enter the collider zone
      IshopCustomerCheck shopCustomerCheck = collider.GetComponent<IshopCustomerCheck>();
      
      if(shopCustomerCheck != null){
          uiShopBuy.ShowShop(shopCustomerCheck);
          uiShopSell.ShowShop(shopCustomerCheck);
          uiShopSell.HideShop();

      }

  } 
   void OnTriggerExit2D( Collider2D collider){ //Checking if anyone exit the collider zone, if so hides all stores
      IshopCustomerCheck shopCustomerCheck = collider.GetComponent<IshopCustomerCheck>();
      
      if(shopCustomerCheck != null){
          uiShopBuy.HideShop();
          uiShopSell.HideShop();
      }


  } 
}
