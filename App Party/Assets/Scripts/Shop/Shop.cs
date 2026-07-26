using Unity.VisualScripting;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private Event PizzaBought;  
    [SerializeField] private Item shopItem;  
    [SerializeField] private Player player;  


    public void ButtonClicked()
    {
        if (player.money >= shopItem.Price) 
        {        
            PizzaBought.Raise(this, shopItem);
            player.SubtractMoney(shopItem.Price);
            print("Rasing this event now!!");
        }
    }
}
