﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Winner : MonoBehaviour
{ 

    public Canvas PlayAgain;

    HealthScript player;
    PauseScript pauseGame;
    public GameObject p1;
    public GameObject p2;
    public Text winningText;

    // Use this for initialization
    void Start()
    {
        PlayAgain.GetComponent<Canvas>();

        pauseGame = GetComponent<PauseScript>();
        PlayAgain.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (p1 != null)
        {
            if (p1.gameObject.GetComponent<HealthScript>().currentHealth <= 0 && p2.gameObject.GetComponent<HealthScript>().currentHealth > 0)
            {
                winningText.text = "Player 2 Wins!";
                pauseGame.pauseText.text = " ";
                pauseGame.paused = true;
               
                PlayAgain.enabled = true;

            }
        }

        if ( p2 != null)
        { 
                if (p2.gameObject.GetComponent<HealthScript>().currentHealth <= 0 && p1.gameObject.GetComponent<HealthScript>().currentHealth > 0)
            {
                winningText.text = "Player 1 Wins!";
                pauseGame.pauseText.text = " ";
                pauseGame.paused = true;
                PlayAgain.enabled = true;
                
            }
        }
    }

    public void ClickYes()
    {
        Application.LoadLevel(2);
    }

    public void ClickNo()
    {
        Application.Quit();

    }

    public void GoBack()
    {
        Application.LoadLevel(0);

    }

}
