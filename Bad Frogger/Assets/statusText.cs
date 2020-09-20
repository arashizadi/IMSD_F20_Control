using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statusText : MonoBehaviour
{
    public Text text;
    public int score;
    public int damage;
    public int time;
    private float timer;
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
        score = 0; damage = 0; time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText(score, damage);
        timeCount();
        damageCount();
        scoreCount();

        if (damage >= 5)
        {
            scoreText("Game Over");
            if (playerObject != null)
                Destroy(playerObject);
        }
    }

    public void scoreText(string _status)
    {
        if (_status == "Game Over")
        {
            text.text = _status + " | Score: " + score.ToString() + " | Elapsed Time: " + time.ToString();
        }
        else
            text.text = _status;
    }

    public void scoreText(int _score, int _damage)
    {
        text.text = "Score: " + _score.ToString() + " | Damage: " + _damage + " Time: " + time.ToString();
    }

    public void timeCount()
    {
        if (playerObject != null)
        {
            timer += Time.deltaTime;
            if (timer >= 1)
            {
                timer = 0;
                time += 1;
            }
        }
    }

    public void damageCount()
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
                timer += Time.deltaTime;
                if (timer >= 0.25)
                {
                    timer = 0;
                    damage += 1;
                }
            }
        }
    }

    public void scoreCount()
    {
        if (playerObject != null)
        {
            if (Math.Round(pillPosition.position.x) == Math.Round(playerPosition.position.x) & Math.Round(pillPosition.position.y) == Math.Round(playerPosition.position.y))
            {
                timer += Time.deltaTime;
                if (timer >= 0.25)
                {
                    timer = 0;
                    score += 1;
                    pillPosition.position = new Vector3(UnityEngine.Random.Range(-10f, 10f), UnityEngine.Random.Range(-9.2f, 1.42f), 0);
                    if (pillPosition.position.x < -10 || pillPosition.position.y <-9.2f || pillPosition.position.x < 10 || pillPosition.position.y < 1.42f)
                    {
                        pillPosition.position = new Vector3(0, 0, 0);
                        pillPosition.position += new Vector3(UnityEngine.Random.Range(-10f, 10f), UnityEngine.Random.Range(-9.2f, 1.42f), 0);
                    }
                }
            }
        }
    }

    public void scoreColor()
    {

    }
}
