using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecting : MonoBehaviour
{
    public int winningThreshold;
    private int _collected;
    private bool _wonGame;

    private void Start()
    {
        _collected = 0;
        _wonGame = false;
        // Find game object by tag and set length as winning threshold.
        winningThreshold = GameObject.FindGameObjectsWithTag("collectable").Length-1;
        // Find game object by name.
        // Game.Object.Find("Cube");
    }

    private void LateUpdate()
    {
        if (_collected > winningThreshold && _wonGame != true)
        {
            Debug.Log("You won!");
            Debug.Log("It took you " + Time.realtimeSinceStartup + "to win the game.");
            
            // Additional message stating if it took you too long to finish the game.
            if (Time.realtimeSinceStartup < 10f)
            {
                Debug.Log("Amazing time!");
            }
            else if (Time.realtimeSinceStartup < 15f)
            {
                Debug.Log("Not too bad I guess...");
            }
            else {Debug.Log("Try again to beat your time score.");}
            
            // Flag to stop the console from printing messages.
            _wonGame = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("collectable"))
        {
            // Disable component.
            // other.enabled = false;
            
            // Disable object.
            // other.gameObject.SetActive(false);
            
            _collected++;
            // Debug.Log(_collected + " points collected.");
            Debug.Log(string.Format("{0} points collected.", _collected));
            Destroy(other.gameObject);
        }
    }
}
