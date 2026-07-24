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


    public void SetChoosenItem(string PreferenceType, string item)
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
