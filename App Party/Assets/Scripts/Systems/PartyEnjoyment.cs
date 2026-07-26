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
        int count = CountMatchingFields(player);

       
    }
    // this has to 
    private int CountMatchingFields(Player player)
    {
        int matchingCount = 0;
        foreach (var item in foodItems)
        {
            if (item.Name == player.foodItem.Name)
                matchingCount++;

        }

        foreach (var item in drinkItems)
        {

            if (item.Name == player.drinkItem.Name)
                matchingCount++;
  
        }


        foreach (var item in gameItems)
        {
            if (item.Name == player.gameItem.Name)
                matchingCount++;

        }

/*
        if (matchingCount == 3)
        {
            //print("Everything matched you get extra points!!");
            matchingCount++;
        }*/

        return matchingCount;
    }
      
    
   /* private void CollectPartyPreferences()
    {

        foreach (var item in foodItems)
        {


            preferenceMatches = CountMatchingFields(item, player);
            
        }

        foreach (var item in drinkItems)
        {


            preferenceMatches = CountMatchingFields(item, player);
            
        }


        foreach (var item in gameItems)
        {


            preferenceMatches = CountMatchingFields(item, player);
            
        }


    }*/

    public int CalculatePartyEnjoyment()
    {
        return 0;
    }

    public int GetPreferenceMatches()
    {
        return preferenceMatches;
    }

}
