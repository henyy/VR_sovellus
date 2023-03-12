using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonPress : MonoBehaviour
{
    bool isPressed = false;
    public GameObject DoorToBeOpened;
    private Animator anim;

    public float timeRemaining;
    public bool timerIsRunning = false;
    public TextMeshPro timeText;

    void Start()
    {
        anim = DoorToBeOpened.GetComponent<Animator>();
    }

    void Update()
    {
        if (isPressed)
        {
            anim.SetBool("ButtonPressed", true);
            timerIsRunning = true;

        }

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                isPressed = false;
                timeText.text = "Press";
                anim.SetBool("ButtonPressed", false);
            }
        }
    }

    public void PressButton()
    {
        isPressed = true;
        timeRemaining = 15f;

    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
