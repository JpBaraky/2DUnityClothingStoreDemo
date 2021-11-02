using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [Header("Movement Settings")] 
       public float moveSpeed; //Sets player movement speed.
    public Rigidbody2D playerRigidbody; 
    Vector2 movement;
    
    void Start(){
        playerRigidbody = GetComponent<Rigidbody2D>();//Sets player rigidbody automatic 
    }
    void Update()
    {
        //## Geting the Axis of the movement
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");
       //##

       

    }
    void FixedUpdate(){
        playerRigidbody.MovePosition(playerRigidbody.position + movement * moveSpeed * Time.fixedDeltaTime); //Movement in Fixed Update for better consistence no matter the fps.

    }
}
