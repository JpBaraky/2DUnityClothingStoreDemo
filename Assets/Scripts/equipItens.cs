using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class equipItens : MonoBehaviour
{
    private playerScript playerScript;
     [Header("Renderer and Sprites")]
    public SpriteRenderer[] playerCloths; 
    public Sprite[] playerBoots;
    public Sprite[] playerShirt;
   
    public Sprite[] playerHat;


    void Start(){
         playerScript = FindObjectOfType(typeof(playerScript)) as playerScript;
    }
    //Function to equip the player with the itens he bought
    
    public void EquipItem(int bodyPart, int itemSprite){ //Boots is 0, Shirt is 1, Hat is 2. Setting the right code and item equipped to the player
   if(bodyPart == 0){
        playerCloths[bodyPart].sprite = playerBoots[itemSprite];
        playerScript.playerCurrentItensCodes[0] = itemSprite; 
    } 
    if(bodyPart == 1 && itemSprite != 0){
        playerCloths[bodyPart].sprite = playerShirt[itemSprite];
      
        playerScript.playerCurrentItensCodes[1] = itemSprite + 3;
            }
   
    if(bodyPart == 2 && itemSprite != 0){
        playerCloths[bodyPart].sprite = playerHat[itemSprite];
        playerScript.playerCurrentItensCodes[2] = itemSprite + 6; 
    }
    if(bodyPart == 1 && itemSprite == 0){
        playerCloths[bodyPart].sprite = playerShirt[itemSprite];
      
        playerScript.playerCurrentItensCodes[1] = 0;
            }
   
    if(bodyPart == 2 && itemSprite == 0){
        playerCloths[bodyPart].sprite = playerHat[itemSprite];
        playerScript.playerCurrentItensCodes[2] = 0; 
    }
    
    
    }
}
