﻿using UnityEngine;
using System;

public class NoteActivationToggle : MonoBehaviour
{
    public GameObject Note;
    private bool _isTimeStopped = false;
    public GameObject Eshka;

    private void Update()
    {
        // Check if the ESC key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Deactivate the Note object
            Note.SetActive(false);

            // Resume time
            _isTimeStopped = false;
            Time.timeScale = 1f;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Eshka.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                // Check if the Note object is active
                if (Note.activeSelf)
                {
                    // Deactivate the Note object
                    Note.SetActive(false);

                    // Resume time
                    _isTimeStopped = false;
                    Time.timeScale = 1f;
                }
                else
                {
                    // Activate the Note object
                    Note.SetActive(true);

                    // Stop time
                    _isTimeStopped = true;
                    Time.timeScale = 0f;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the object that exited the trigger is the player
        if (other.gameObject.CompareTag("Player"))
        {
            // Deactivate the Eshka object
            Eshka.SetActive(false);
        }
    }
}