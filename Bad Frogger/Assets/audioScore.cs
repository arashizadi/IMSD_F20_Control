using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioScore : MonoBehaviour
{
    private float timer;
    private AudioSource audioSource;
    public GameObject playerObject;
    public Transform playerPosition;
    public Transform pillPosition;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerObject != null)
        {
            if (Math.Round(pillPosition.position.x) == Math.Round(playerPosition.position.x) & Math.Round(pillPosition.position.y) == Math.Round(playerPosition.position.y))
            {
                if (!audioSource.isPlaying)
                    audioSource.Play();
            }

        }
    }
}
