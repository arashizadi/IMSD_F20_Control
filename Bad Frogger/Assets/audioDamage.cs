using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioDamage : MonoBehaviour
{
    private float timer;
    private AudioSource audioSource;
    public GameObject playerObject;
    public Transform playerPosition;
    public Transform pillPosition;
    public Transform enemyOne;
    public Transform enemyTwo;
    public Transform enemyThree;
    public Transform enemyFour;
    public Transform enemyFive;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        damageSFX();
    }

    public void damageSFX()
    {
        if (playerObject != null)
        {
            if (
            (Math.Round(enemyOne.position.x) == Math.Round(playerPosition.position.x) & Math.Round(enemyOne.position.y) == Math.Round(playerPosition.position.y)) ||
            (Math.Round(enemyTwo.position.x) == Math.Round(playerPosition.position.x) & Math.Round(enemyTwo.position.y) == Math.Round(playerPosition.position.y)) ||
            (Math.Round(enemyThree.position.x) == Math.Round(playerPosition.position.x) & Math.Round(enemyThree.position.y) == Math.Round(playerPosition.position.y)) ||
            (Math.Round(enemyFour.position.x) == Math.Round(playerPosition.position.x) & Math.Round(enemyFour.position.y) == Math.Round(playerPosition.position.y)) ||
            (Math.Round(enemyFive.position.x) == Math.Round(playerPosition.position.x) & Math.Round(enemyFive.position.y) == Math.Round(playerPosition.position.y))
            )
            {
                if (!audioSource.isPlaying)
                    audioSource.Play();
            }
        }
    }
}
