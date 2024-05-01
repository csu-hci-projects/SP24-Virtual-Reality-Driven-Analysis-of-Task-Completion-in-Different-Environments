using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuOptions : MonoBehaviour
{
     float timer = 300f; // 5 minutes in seconds
    private bool timerRunning = false;
    public TMP_Text timerText;
    int ttc = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        // We don't start the timer automatically anymore
         StartTimer();
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
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            ttc = Mathf.FloorToInt(timer);
            ttc = 300 - ttc;
           // print("completion time: " + ttc + "Current Scene index: " + currentSceneIndex);
    }

    
    //public void StartTimerOnClick()
    //{
   //     StartTimer();
   // }

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
        ttc = seconds;
        timerText.text = seconds.ToString();
    }

    public void LoadNextScene()
    {
        
          int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
       
        //int seconds = Mathf.FloorToInt(timer);
        //int seconds = Mathf.FloorToInt(timer);
        //string time = seconds.ToString();
        print("TTC TIME current scene: " + currentSceneIndex + " time to complete: " + ttc);
        print("TIMER TIME current scene:" + currentSceneIndex + "time to complete: " +  timer );
        
        SceneManager.LoadScene(currentSceneIndex + 1);
    }


  

    
}
