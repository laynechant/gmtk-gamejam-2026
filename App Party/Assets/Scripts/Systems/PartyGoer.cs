using System;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPartyGoer", menuName = "ScritableObjects/PartGoer")]
public class PartyGoer : ScriptableObject
{

    public Preferences preferences;

    /// <summary>
    /// this is for holding the different types of objects the player can get for the party
    /// and to compare whether the right object was grabbed for the people 
    /// </summary>

    [Serializable]

    public struct Preferences
    {
        [Tooltip("What this person prefers to have at a party")]
        public Food.FoodTypes foods;
        public Drinks.DrinkTypes drinks;
        public Music.MusicTypes music;
        public Games.GameTypes games;

    }
}
