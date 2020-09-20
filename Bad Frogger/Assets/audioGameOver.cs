using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioGameOver : MonoBehaviour
{
    private float timer;
    private AudioSource audioSource;
    public GameObject playerObject;
    private bool gameRunning;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        gameRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerObject == null & gameRunning)       //GAMEOVER SFX
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
                gameRunning = false;
            }
            else
                audioSource.Stop();
        }
    }
}
