using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameController : MonoBehaviour

{
    private playerScript playerScript;
    public int playerGold; //Stores player gold.
    public TextMeshProUGUI goldTxt; //Text variable for the gold
    
    void Start()
    {
        playerScript = FindObjectOfType(typeof(playerScript)) as playerScript; //Gets the player script and put in a variable
        playerGold+= 150;
        
    }

  
    void Update()
    {
        goldTxt.text = playerGold.ToString("N0"); //geting the players gold and puting in a string
    }
}
