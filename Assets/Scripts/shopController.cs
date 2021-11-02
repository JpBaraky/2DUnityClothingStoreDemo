using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopController : MonoBehaviour
{
  
    private Transform containerStore;
    private Transform storeButtonTemplate;
    void Start()
    {
        containerStore = transform.Find("Container Store"); //Finds and puts the Container Store of the UI in a variable
        storeButtonTemplate = containerStore.Find("Store Button Template");//Finds inside the container and puts the template for the button in a variable.
        storeButtonTemplate.gameObject.SetActive(false); //Starting with the template hidden
    }

       void Update()
    {
        
    }
}
