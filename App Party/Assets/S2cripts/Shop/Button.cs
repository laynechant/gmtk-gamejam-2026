using UnityEngine;


public class Button : MonoBehaviour
{

    [SerializeField] private Event itemBought;
    [SerializeField] private Item itemType;

    // add a check to see whether the max amount of items was bought
    // so you cant just spam this and waste all your money
    public void ButtonClicked()
    {
        if (Player.Instance.money >= itemType.Price)
        { 
            itemBought.Raise(this, itemType);
            Player.Instance.SubtractMoney(itemType.Price);

        }
    }
}
