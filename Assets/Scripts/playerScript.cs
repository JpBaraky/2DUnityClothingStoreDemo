using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour, IshopCustomerCheck
{
    private gameController gameController;
    private equipItens equipItens;
    [Header("Movement Settings")]
    public float moveSpeed; //Sets player movement speed.
    Rigidbody2D playerRigidbody;
    Vector2 movement;

    void Start()
    {
        gameController = FindObjectOfType(typeof(gameController)) as gameController;
        equipItens = FindObjectOfType(typeof(equipItens)) as equipItens;
        playerRigidbody = GetComponent<Rigidbody2D>();//Sets player rigidbody automatic 
    }
    void Update()
    {
        //## Geting the Axis of the movement
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        //##



    }
    void FixedUpdate()
    {
        playerRigidbody.MovePosition(playerRigidbody.position + movement * moveSpeed * Time.fixedDeltaTime); //Movement in Fixed Update for better consistence no matter the fps.

    }
    public void BougthItem(shopItems.ItemTypes itemTypes)
    { //Verify who is accessing the shop and what item hes bought

        Debug.Log("Bought Item: " + itemTypes);
        /* switch(itemTypes){ //Each bought item will call a different function and equip it to the player
             case shopItems.ItemTypes.ShirtNone: equipItens.EquipShirtNone(); break;
             case shopItems.ItemTypes.Shirt_1: equipItens.EquipShirt1(); break;
             case shopItems.ItemTypes.Shirt_2: equipItens.EquipShirt2(); break;
             case shopItems.ItemTypes.BootsNone: equipItens.EquipBootsNone(); break;
             case shopItems.ItemTypes.Boots_1: equipItens.EquipBoots1(); break;
             case shopItems.ItemTypes.Boots_2: equipItens.EquipBoots2(); break;
             case shopItems.ItemTypes.HatNone: equipItens.EquipHatNone(); break;
             case shopItems.ItemTypes.Hat_1: equipItens.EquipHat1(); break;
             case shopItems.ItemTypes.Hat_2: equipItens.EquipHat2(); break;
         } */
    }
    public bool TrySpendGold(int goldAmount) //Verify if the player have the gold necessary to buy a item.
    {
        if (gameController.playerGold >= goldAmount)
        {
            gameController.playerGold -= goldAmount;
            return true;
        }
        else
        {

            return false;
        }
    }

     public void SellItem(shopItems.ItemTypes itemTypes) 
    {
        Debug.Log("Selled Item: " + itemTypes);
        switch (itemTypes)
        { //Each sell item will call a different function  it to the player
            case shopItems.ItemTypes.Shirt_1:
                {
                   // equipItens.EquipShirtNone();
                    
                    break;
                }
            case shopItems.ItemTypes.Shirt_2:
                {
                    //equipItens.EquipShirtNone();
                     break;
                }
            case shopItems.ItemTypes.Boots_1:
                {
                   // equipItens.EquipBootsNone(); 
                    break;
                }
            case shopItems.ItemTypes.Boots_2:
                {
                    //equipItens.EquipBootsNone();
                    
                    break;
                }
            case shopItems.ItemTypes.Hat_1:
                {
                    //equipItens.EquipHatNone(); 
                    break;
                }
            case shopItems.ItemTypes.Hat_2:
                {
                    //equipItens.EquipHatNone(); 
                    break;
                }

        }


    }

    

    public bool TrySellItem(int goldAmount)
    {
        
        gameController.playerGold += goldAmount;
        return true;
        

    }
}
