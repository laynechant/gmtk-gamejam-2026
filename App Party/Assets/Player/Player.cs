using System;
using UnityEngine;


public class Player : MonoBehaviour
{
    public ChoosenItems choosenItems;

    [Serializable]
    public struct ChoosenItems
    {
        public Food.FoodTypes foodType;
        public Drinks.DrinkTypes drinks;
        public Music.MusicTypes music;
        public Games.GameTypes games;
    }


    public void GetChoosenItem(Component sender, object data)
    {
        if (data is string item)
        {
           
            // need to figure out what the player bought so we can decide what to 
            // set it to
            // maybe we cxould try parsing it to each different enum and then the ones that return true we 
            // know wh have a good match??

            if (Enum.TryParse<Food.FoodTypes>(item, out Food.FoodTypes result))
            {

                switch(result)
                {
                    case Food.FoodTypes.Pizza:
                        choosenItems.foodType = Food.FoodTypes.Pizza;
                        break;

                    case Food.FoodTypes.Chips:
                        choosenItems.foodType = Food.FoodTypes.Chips;
                        break;

                    case Food.FoodTypes.Wings:
                        choosenItems.foodType = Food.FoodTypes.Wings;
                        break;


                    case Food.FoodTypes.Sliders:
                        choosenItems.foodType = Food.FoodTypes.Sliders;
                        break;

                    case Food.FoodTypes.Nachos:
                        choosenItems.foodType = Food.FoodTypes.Nachos;
                        break;

                    default: 

                        break;
                }
               
            }

            
      
        }
    }


    public void SetChoosenItem(ChoosenItems item)
    {

    }
    /*public enum ChoosenItems
    {
      pizza, 
      beer,
      rap,
      pong
    }*/


    /*
      potential functions for this class
        
      should be a func to get the items that the player bought from the shop

      need to be able to track the amount of money the player has so you can buy objects properly 
     
     */
}
