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
    public void BougthItem(shopItems.ItemTypes itemTypes){ //Verify who is accessing the shop and what item hes bought
        
        Debug.Log("Bought Item: " + itemTypes );
    }

    public bool TrySpendGold(int goldAmount) //Verify if the player have the gold necessary to buy a item.
    {
       if(gameController.playerGold >= goldAmount){
           gameController.playerGold -= goldAmount;
           return true;
       }
       else{
           return false;
       }
    }
    
}
