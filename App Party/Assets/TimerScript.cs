using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public int num;
    [SerializeField] TMP_Text Timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int hours = Mathf.FloorToInt(num / 60F);
        int min = Mathf.FloorToInt(num - hours * 60);

        Timer.text = string.Format("{00}:{1:00}", hours, min);
    }
}
