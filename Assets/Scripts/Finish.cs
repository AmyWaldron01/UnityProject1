using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource endSound; // The audio source for the finish sound effect.
    private bool finishedLevel = false; // Flag indicating whether the level is completed.

    private void Start()
    {
        // Get the AudioSource component from the game object.
        endSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the player has collided with the object and the level is not yet completed.
        if (collision.gameObject.name == "Player" && !finishedLevel)
        {
            // Play the finish sound effect.
            endSound.Play();
            
            // Set the level as completed and delay loading the next level.
            finishedLevel = true;
            Invoke("LoadNextLevel", 2f);
        }
    }

    private void LoadNextLevel()
    {
        // Load the next level in the build order.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }   
}