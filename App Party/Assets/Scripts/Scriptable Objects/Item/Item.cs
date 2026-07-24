using System;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPartyItem", menuName = "ScritableObjects/PartyItem")]
public class Item : ScriptableObject
{
    [Serializable]
    public enum Category
    {
        Food, 
        Drink, 
        Game
    }
    [Serializable]
    public enum SubCategory
    {
        Pizza,
        Wings,
        Chips,
        Dessert,
        Water,
        Juice,
        Beer,
        Soda,
        CouchCoop,
        Drinking,
        Board
    }
    public Category category;
    public SubCategory subCategory;
    public string Name;
    public int Price;
}
