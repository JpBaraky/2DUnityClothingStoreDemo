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
    public void EquipShirt1(){
        playerCloths[0].sprite = playerShirt[1];
    }
    public void EquipShirt2(){

    }
    public void EquipBootsNone(){

    }
    public void EquipBoots1(){

    }
    public void EquipBoots2(){

    }
    public void EquipHatNone(){

    }
    public void EquipHat1(){

    }
    public void EquipHat2(){

    }
}
