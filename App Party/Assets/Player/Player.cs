using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Player : MonoBehaviour
{

    [SerializeField] public Item foodItem;
    [SerializeField] public Item drinkItem;
    [SerializeField] public Item gameItem;


    [SerializeField] private GameObject UIObject;
    [SerializeField] private GameObject ItemList;
    [SerializeField] private TextMeshProUGUI MoneyUI;

    private int counter = 0;

    public int money = 200;

    public static Player Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        MoneyUI.text = ("$" + money.ToString());

    }

    public void GetChoosenItem(Component sender, object data)
    {
        if (data is Item item)
            {

                switch (item.category)
                {
                    case Item.Category.Food:
                        foodItem = item;
                        break;

                    case Item.Category.Drink:
                        drinkItem = item;
                        break;


                    case Item.Category.Game:
                        gameItem = item;
                        break;

                }

                DisplayChoosenItem(item.Name, UIObject);
            }
    }

    public void DisplayChoosenItem(string name, GameObject UiObject)
    {

        if (counter <= 2)
        {
            name = foodItem.Name;

            GameObject newItem = Instantiate(UiObject, ItemList.transform);
            var textComponent = newItem.GetComponentInChildren<TextMeshProUGUI>();
            textComponent.text = name;
        
            counter++;
        }
       
    }

    public void SubtractMoney (int amount)
    {
        money -= amount;
       
    }
    /*
      potential functions for this class
        
      should be a func to get the items that the player bought from the shop

      need to be able to track the amount of money the player has so you can buy objects properly 
     
     */
}
