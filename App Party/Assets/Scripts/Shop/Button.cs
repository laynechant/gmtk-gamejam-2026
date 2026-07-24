using UnityEngine;

public class Button : MonoBehaviour
{

    [SerializeField] private Event itemBought;
    [SerializeField] private Item itemType;


    public void ButtonClicked()
    {
        itemBought.Raise(this, itemType);
    }
}
