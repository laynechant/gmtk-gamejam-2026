using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Canvas winCanvas;
    [SerializeField] private Canvas loseCanvas;


    [SerializeField] private PartyEnjoyment partyEnjoyment;

    private void Update()
    {
        int totalPoints = partyEnjoyment.CountMatchingFields();
        print(totalPoints);
        if (totalPoints >= 2)
        {
            //print("hisiis");
            winCanvas.enabled = true;
        }
        else
        {
            loseCanvas.enabled = true;
        }
    }

}
