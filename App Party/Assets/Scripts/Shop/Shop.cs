using Unity.VisualScripting;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private Event PizzaBought;  
    [SerializeField] private Item partyItem;  


    public void ButtonClicked()
    {
        PizzaBought.Raise(this, partyItem);
        print("Rasing this event now!!");
    }
}
