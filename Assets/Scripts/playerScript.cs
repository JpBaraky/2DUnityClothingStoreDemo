using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour, IshopCustomerCheck
{
    private gameController gameController;
    private equipItens equipItens;
    [Header("Player Equipped Items")]

    public int[] playerCurrentItensCodes;
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
        switch (itemTypes)
        { //Each bought item will call a different function and equip it to the player    
            case shopItems.ItemTypes.BootsNone: equipItens.EquipItem(0, 0); break;
            case shopItems.ItemTypes.Boots_1: equipItens.EquipItem(0, 1); break;
            case shopItems.ItemTypes.Boots_2: equipItens.EquipItem(0, 2); break;
            case shopItems.ItemTypes.Boots_3: equipItens.EquipItem(0, 3); break;

            case shopItems.ItemTypes.ShirtNone: equipItens.EquipItem(1, 0); break;
            case shopItems.ItemTypes.Shirt_1: equipItens.EquipItem(1, 1); break;
            case shopItems.ItemTypes.Shirt_2: equipItens.EquipItem(1, 2); break;
            case shopItems.ItemTypes.Shirt_3: equipItens.EquipItem(1, 3); break;

            case shopItems.ItemTypes.HatNone: equipItens.EquipItem(2, 0); break;
            case shopItems.ItemTypes.Hat_1: equipItens.EquipItem(2, 1); break;
            case shopItems.ItemTypes.Hat_2: equipItens.EquipItem(2, 2); break;
            case shopItems.ItemTypes.Hat_3: equipItens.EquipItem(2, 3); break;
        }
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
        { 
            case shopItems.ItemTypes.BootsNone: equipItens.EquipItem(0, 0); break;
            case shopItems.ItemTypes.ShirtNone: equipItens.EquipItem(1, 0); break;
            case shopItems.ItemTypes.HatNone: equipItens.EquipItem(2, 0); break;
        }


    }



    public bool TrySellItem(int goldAmount, int GetItemCode)
    {
        Debug.Log("item code"+ GetItemCode +"current item " + playerCurrentItensCodes[0]);
        
          
            if (playerCurrentItensCodes[0] == GetItemCode)
            {
                
                gameController.playerGold += goldAmount;
                playerCurrentItensCodes[0] = 0;
               equipItens.EquipItem(0, 0);
                return true;
            } 
            if (playerCurrentItensCodes[1] == GetItemCode)
            {
                
                gameController.playerGold += goldAmount;
                playerCurrentItensCodes[1] = 0;
               equipItens.EquipItem(1, 0);
                return true;
            } 
            if (playerCurrentItensCodes[2] == GetItemCode)
            {
                
                gameController.playerGold += goldAmount;
                playerCurrentItensCodes[2] = 0;
               equipItens.EquipItem(2, 0);
                return true;
            } 

        
      
        return false;





    }


}
