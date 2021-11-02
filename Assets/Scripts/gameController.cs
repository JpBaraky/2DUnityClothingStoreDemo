using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameController : MonoBehaviour

{
    private playerScript playerScript;
    public int playerGold; //Stores player gold.
    public TextMeshProUGUI goldTxt;
    
    void Start()
    {
        playerScript = FindObjectOfType(typeof(playerScript)) as playerScript;
         
        
    }

  
    void Update()
    {
        goldTxt.text = playerGold.ToString("N0");
    }
}
