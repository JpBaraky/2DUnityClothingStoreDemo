using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopTriggerCollider : MonoBehaviour
{
  [SerializeField] private shopController uiShop; // Recives what is the Ui of the shop
   void OnTriggerEnter2D( Collider2D collider){ //Checking if anyone enter the collider zone
      IshopCustomerCheck shopCustomerCheck = collider.GetComponent<IshopCustomerCheck>();
      Debug.Log("Enter Trigger");
      if(shopCustomerCheck != null){
          uiShop.ShowShop(shopCustomerCheck);
      }

  } 
   void OnTriggerExit2D( Collider2D collider){ //Checking if anyone exit the collider zone
      IshopCustomerCheck shopCustomerCheck = collider.GetComponent<IshopCustomerCheck>();
      Debug.Log("Exit Trigger");
      if(shopCustomerCheck != null){
          uiShop.HideShop();
      }

  } 
}
