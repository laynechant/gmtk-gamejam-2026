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
    [SerializeField] private List<Item> jonsPreferences;
    [SerializeField] private List<Item> mercedesPreferences;
    [SerializeField] private List<Item> charliePreferences;

    // now we get the players pref
    [SerializeField] private Player player;

    private int preferenceMatches = 0;

 

    // Update is called once per frame
    void Update()
    {

    }

    private int CountMatchingFields(Player player)
    {
        int matchingCount = 0;
        foreach (var item in jonsPreferences)
        {
            if (item.Name == player.foodItem.Name)
                matchingCount++;

        }

        foreach (var item in mercedesPreferences)
        {

            if (item.Name == player.drinkItem.Name)
                matchingCount++;
  
        }


        foreach (var item in charliePreferences)
        {
            if (item.Name == player.gameItem.Name)
                matchingCount++;

        }

        return matchingCount;
    }
      


    public int CalculateExtraPoints()
    {
        
        int basePoints = CountMatchingFields(player);
        int extraPoint = 0;
        if (basePoints == 3)
        {
            extraPoint = 1;
        }

        return basePoints + extraPoint;
    }

    public int GetPreferenceMatches()
    {
        return preferenceMatches;
    }

}
