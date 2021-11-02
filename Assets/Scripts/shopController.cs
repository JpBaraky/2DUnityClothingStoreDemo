using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class shopController : MonoBehaviour
{
  
    private Transform containerStore;
    private Transform storeButtonTemplate;
    private Image containerImage;
    private Button buyButton;
    void Awake()
    {
        containerStore = transform.Find("ContainerStore"); //Finds and puts the Container Store of the UI in a variable
        containerImage = containerStore.GetComponent<Image>();
        storeButtonTemplate = containerStore.Find("StoreButtonTemplate");//Finds inside the container and puts the template for the button in a variable.
        storeButtonTemplate.gameObject.SetActive(false); //Starting with the template hidden, he stays hidden because he is there just to be cloned
        containerImage.enabled = false; //The container starts hidden too, but turn on when is needed

    }
    private void Start(){
        CreateStoreButton(shopItems.ItemTypes.Boots_1, shopItems.GetSprite(shopItems.ItemTypes.Boots_1),  shopItems.GetCost(shopItems.ItemTypes.Boots_1), -1);
        CreateStoreButton(shopItems.ItemTypes.Hat_2, shopItems.GetSprite(shopItems.ItemTypes.Hat_2),  shopItems.GetCost(shopItems.ItemTypes.Hat_2), 0);
        CreateStoreButton(shopItems.ItemTypes.Shirt_1, shopItems.GetSprite(shopItems.ItemTypes.Shirt_1),  shopItems.GetCost(shopItems.ItemTypes.Shirt_1), 1);
           }
    

       private void CreateStoreButton(shopItems.ItemTypes itemType, Sprite itemSprite, int itemCost, int positionIndex){ //Name, cost, sprite and position of each shop button.
           Transform shopItemTransform = Instantiate(storeButtonTemplate, containerStore);
        shopItemTransform.gameObject.SetActive(true);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 250f; // Distance between the buttons of the shop
        shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex);

        
        shopItemTransform.Find("Item Price").GetComponent<TextMeshProUGUI>().SetText(itemCost.ToString());

        shopItemTransform.Find("Store Item").GetComponent<Image>().sprite = itemSprite;

        buyButton = shopItemTransform.GetComponent<Button>();
        buyButton.onClick.AddListener(delegate {TryBuyItem(itemType); });

            
            
       }
         public void TryBuyItem(shopItems.ItemTypes itemType){
             Debug.Log(itemType);

        } 

        
         //Geting the click on the shop button 

                  
       }

