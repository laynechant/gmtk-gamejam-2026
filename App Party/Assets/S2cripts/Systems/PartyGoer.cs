using System;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPartyGoer", menuName = "ScritableObjects/PartyGoer")]
public class PartyGoer : ScriptableObject
{

   public Item Food;
   public Item Drinks;
   public Item Games;

    /// <summary>
    /// this is for holding the different types of objects the player can get for the party
    /// and to compare whether the right object was grabbed for the people 
    /// </summary>

}
