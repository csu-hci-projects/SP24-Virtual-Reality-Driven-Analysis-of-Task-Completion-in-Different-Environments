using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartGame : MonoBehaviour
{
    private float timer = 300f; // 5 minutes in seconds
    private bool timerRunning = false;
    public TMP_Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        // We don't start the timer automatically anymore
        // StartTimer();
    }

    void Update()
    {
        if (timerRunning)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                // Load the next scene
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

            UpdateTimerDisplay();
        }
    }

    // Method to start the timer when the button is clicked
    public void StartTimerOnClick()
    {
        StartTimer();
    }

    public void StartTimer()
    {
        timerRunning = true;
    }

    public void StopTimer()
    {
        timerRunning = false;
    }

    void UpdateTimerDisplay()
    {
        int seconds = Mathf.FloorToInt(timer);

        timerText.text = seconds.ToString();
    }
}
