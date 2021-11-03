using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class shopController : MonoBehaviour
{
  
    private Transform containerStore;
    private Transform storeButtonTemplate;
   
    private Button buyButton;
    private IshopCustomerCheck shopCustomerCheck;
     public bool shopIsBuy;
   
    void Awake()
    {
        containerStore = transform.Find("ContainerStore"); //Finds and puts the Container Store of the UI in a variable
      
        storeButtonTemplate = containerStore.Find("StoreButtonTemplate");//Finds inside the container and puts the template for the button in a variable.
        storeButtonTemplate.gameObject.SetActive(false); //Starting with the template hidden, he stays hidden because he is there just to be cloned
       

    }
    private void Start(){
        //This is not a good way to put items in the shop, but just for a few is fine
        CreateStoreButton(shopItems.ItemTypes.Boots_1, shopItems.GetSprite(shopItems.ItemTypes.Boots_1),  shopItems.GetCost(shopItems.ItemTypes.Boots_1), -1, 5);
        CreateStoreButton(shopItems.ItemTypes.Hat_2, shopItems.GetSprite(shopItems.ItemTypes.Hat_2),  shopItems.GetCost(shopItems.ItemTypes.Hat_2), 0, 9);
        CreateStoreButton(shopItems.ItemTypes.Shirt_1, shopItems.GetSprite(shopItems.ItemTypes.Shirt_1),  shopItems.GetCost(shopItems.ItemTypes.Shirt_1), 1, 2);
    
        HideShop();
           }
    

       private void CreateStoreButton(shopItems.ItemTypes itemType, Sprite itemSprite, int itemCost, int positionIndex, int itemNumber){ //Name, cost, sprite and position of each shop button.
           Transform shopItemTransform = Instantiate(storeButtonTemplate, containerStore);
        shopItemTransform.gameObject.SetActive(true);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 250f; // Distance between the buttons of the shop
        shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex);

        
        shopItemTransform.Find("Item Price").GetComponent<TextMeshProUGUI>().SetText(itemCost.ToString());

        shopItemTransform.Find("Store Item").GetComponent<Image>().sprite = itemSprite;

        buyButton = shopItemTransform.GetComponent<Button>(); 
        
        if(shopIsBuy){
            buyButton.onClick.AddListener(delegate {TryBuyItem(itemType); }); //Geting the click on the shop button to buy an item 
        }
        else{
            buyButton.onClick.AddListener(delegate {TrySellItem(itemType); }); //Geting the click on the shop button to sell an item 
        }
        
            
        

            
            
       }
         public void TryBuyItem(shopItems.ItemTypes itemType){
        
             
            if( shopCustomerCheck.TrySpendGold(shopItems.GetCost(itemType))){ //Verify if the player can afford the item 
             shopCustomerCheck.BougthItem(itemType);
            }
          
            
        } 
        public void TrySellItem(shopItems.ItemTypes itemType){
            if( shopCustomerCheck.TrySellItem(shopItems.GetCost(itemType)))
            shopCustomerCheck.SellItem(itemType); 
        }

        //## Show or Hide the shop when needed
        public void ShowShop(IshopCustomerCheck shopCustomerCheck){ 
            this.shopCustomerCheck = shopCustomerCheck;
            
            gameObject.SetActive(true);

        }
        
        public void HideShop(){
           
            gameObject.SetActive(false);
             
        }
        //##          
       }

