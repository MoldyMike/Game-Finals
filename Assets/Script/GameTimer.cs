using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float timeElapsed = 0f;
    public bool isRunning = true;

    public TMP_Text timerText;

    void Update()
    {
        if (isRunning)
        {
            timeElapsed += Time.deltaTime;
            UpdateTimerUI();
        }
    }

    void UpdateTimerUI()
    {
        if (timerText != null)
        {
            timerText.text = "Time: " + timeElapsed.ToString("F2");
        }
    }

    public void StopTimer()
    {
        isRunning = false;
        Debug.Log("Timer stopped at: " + timeElapsed);
    }
}
