using System;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPartyGoer", menuName = "ScritableObjects/PartyGoer")]
public class PartyGoer : ScriptableObject
{

    [SerializeField] private Item Corn;
    [SerializeField] private Item Drinks;
    [SerializeField] private Item Games;

    //public Preferences preferences;

    // use a list to organize all the SO party items now

    /// <summary>
    /// this is for holding the different types of objects the player can get for the party
    /// and to compare whether the right object was grabbed for the people 
    /// </summary>

    
 /*   public struct Preferences
    {
        [Tooltip("What this person prefers to have at a party")]
        public itfoods;
        public Drinks.DrinkTypes drinks;
        public Music.MusicTypes music;
        public Games.GameTypes games;

    }*/
}
