using System;
using UnityEngine;
using TMPro;


public class Player : MonoBehaviour
{


    [SerializeField] public Item foodItem;
    [SerializeField] public Item drinkItem;
    [SerializeField] public Item gameItem;
    [SerializeField] private TextMeshProUGUI MoneyUI;

    private int counter = 0;

    public int money = 100;

    public static Player instance {  get; private set; }


    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        MoneyUI.text = ("$" + money.ToString());
    }

    // public ChoosenItems choosenItems;

    /*    [Serializable]
        public struct ChoosenItems
        {
            public Food.FoodTypes foodType;
            public Drinks.DrinkTypes drinks;
            public Music.MusicTypes music;
            public Games.GameTypes games;
        }*/


    public void GetChoosenItem(Component sender, object data)
    {
        if (data is Item item)
        {
          
           

            foodItem = item;

        }
    }

    /*
      potential functions for this class
        
      should be a func to get the items that the player bought from the shop

      need to be able to track the amount of money the player has so you can buy objects properly 
     
     */
}
