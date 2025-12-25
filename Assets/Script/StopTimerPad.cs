using UnityEngine;

public class StopTimerPad : MonoBehaviour
{
    public GameTimer gameTimer;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameTimer.StopTimer();
        }
    }
}
