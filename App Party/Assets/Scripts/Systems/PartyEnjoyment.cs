using System.Collections.Generic;
using UnityEngine;

public class PartyEnjoyment : MonoBehaviour
{
    // need to gather all the people that will be attending the party and collect their preferences
    // then compare those against what the player picked to decide how enjoyable the party was 
    // if you fully meet someones party pref you get an extra point 

    // here we have everybodies party pref
    public List<PartyGoer> partyGoers;

    // the list to hold all the party items i made
    [SerializeField] private List<Item> foodItems;
    [SerializeField] private List<Item> drinkItems;
    [SerializeField] private List<Item> gameItems;

    // now we get the players pref
    [SerializeField] private Player player;

    private int preferenceMatches = 0;

 

    // Update is called once per frame
    void Update()
    {

       
    }

    public int CountMatchingFields()
    {
        int totalMatches = 0;
        int bounsPoints = 0;
        int jonMatches = 0;


        foreach (var person in partyGoers)
        {
            int matchesForPerson = 0;

            if (person != null && person.Food.Name == player.foodItem.Name) matchesForPerson++;
            if (person != null && person.Drinks.Name == player.drinkItem.Name) matchesForPerson++;
            if (person != null && person.Games.Name == player.gameItem.Name) matchesForPerson++;
            totalMatches += matchesForPerson;
        }

        if (totalMatches == 3) bounsPoints++;

        return totalMatches + bounsPoints;
    }
      
    
   /* private void CollectPartyPreferences()
    {

        foreach (var item in foodItems)
        {

    /*public int CalculateExtraPoints()
    {
        
        int basePoints = CountMatchingFields();
        int extraPoint = 0;
        if (basePoints == 3)
        {


            preferenceMatches = CountMatchingFields(item, player);
            
        }

        return basePoints + extraPoint;
    }*/

    public int GetPreferenceMatches()
    {
        return preferenceMatches;
    }

}
