using UnityEngine;

[CreateAssetMenu(fileName = "NewPartyItem", menuName = "ScritableObjects/PartyItem")]
public class Item : ScriptableObject
{
    [SerializeField] private string Category;
    [SerializeField] private string SubCategory;
    [SerializeField] private string Name;
    [SerializeField] private int Price;
}
