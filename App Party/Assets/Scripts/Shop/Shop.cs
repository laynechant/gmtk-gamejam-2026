using Unity.VisualScripting;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private Event PizzaBought;  


    public void ButtonClicked(string data)
    {
        PizzaBought.Raise(this, data);
        print("Rasing this event now!!");
    }
}
