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
    //All functions to equip the player with the itens he bought
    public void EquipShirtNone(){


    }
    public void EquipItem(int bodyPart, int itemSprite){ //Boots is 0, Shirt is 1, Hat is 2
    if(bodyPart == 1){
        playerCloths[bodyPart].sprite = playerShirt[itemSprite];
    }
    if(bodyPart == 0){
        playerCloths[bodyPart].sprite = playerBoots[itemSprite];
    }
    if(bodyPart == 2){
        playerCloths[bodyPart].sprite = playerHat[itemSprite];
    }
    }
    public void EquipShirt2(){

    }
    public void EquipShirt3(){

    }
    public void EquipBootsNone(){

    }
    public void EquipBoots1(){

    }
    public void EquipBoots2(){

    }
    public void EquipBoots3(){

    }
    public void EquipHatNone(){

    }
    public void EquipHat1(){

    }
    public void EquipHat2(){

    }
    public void EquipHat3(){

    }
}
