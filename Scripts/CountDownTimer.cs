using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;
    private bool isRunning = false;

    [SerializeField] Text countdownText;

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        if (currentTime <= startingTime && currentTime > 3 )
        {
            isRunning = true;
            countdownText.text = currentTime.ToString("0");
        }
        else if (currentTime <= 3 && currentTime > 0)
        {
            countdownText.color = Color.red;
            countdownText.text = currentTime.ToString("0.0");
        }
        else if (currentTime <= 0)
        {
            countdownText.text = "GAMEOVER";
            isRunning = false;
        }
    }
}
