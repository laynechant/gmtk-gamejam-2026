using System;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPartyGoer", menuName = "ScritableObjects/PartyGoer")]
public class PartyGoer : ScriptableObject
{

   public Item Food;
   public Item Drinks;
   public Item Games;

}
