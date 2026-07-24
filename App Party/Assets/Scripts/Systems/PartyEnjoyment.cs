using System.Collections.Generic;
using UnityEngine;

public class PartyEnjoyment : MonoBehaviour
{
    // need to gather all the people that will be attending the party and collect their preferences
    // then compare those against what the player picked to decide how enjoyable the party was 
    // if you fully meet someones party pref you get an extra point 

    // here we have everybodies party pref
    public List<PartyGoer> partyGoers;

    // now we get the players pref
    [SerializeField] private Player player;

    private int preferenceMatches = 0;

    // Update is called once per frame
    void Update()
    {
        CollectPartyPreferences();
    }

    private int CountMatchingFields(PartyGoer partyGoerItem, Player player)
    {
        int matchingCount = 0;
        if (partyGoerItem.preferences.foods == player.choosenItems.foodType)
        {
            matchingCount++;
        }
        else
        {
            matchingCount--;
        }
        if (partyGoerItem.preferences.drinks == player.choosenItems.drinks)
        {
            matchingCount++;
        }
        else
        {
            matchingCount--;
        }
        if (partyGoerItem.preferences.music == player.choosenItems.music) 
        {
            matchingCount++;
        }
        else
        {
            matchingCount--;
        }
        if (partyGoerItem.preferences.games == player.choosenItems.games) 
        {
           matchingCount++;
        }
        else
        {
            matchingCount--;
        }

        if (matchingCount == 4)
        {
            print("Everything matched you get extra points!!");
            matchingCount++;
        }

        return matchingCount;
    }
      
    
    private void CollectPartyPreferences()
    {

        foreach (var person in partyGoers)
        {
            preferenceMatches = CountMatchingFields(person, player);
            
        }
    }

    public int CalculatePartyEnjoyment()
    {
        return 0;
    }

    public int GetPreferenceMatches()
    {
        return preferenceMatches;
    }

}
