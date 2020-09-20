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
    public Transform player;
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
        if (damage >= 5)
        {
            scoreText("Game Over");
        }
    }
    public void scoreText(string _status)
    {
        text.text = _status;
    }
    public void scoreText (int _score, int _damage)
    {
        text.text = "Score: " + _score.ToString() + " | Damage: " + _damage + " Time: " + time.ToString();
    }
    public void timeCount()
    {
        timer += Time.deltaTime;
        if (timer >= 1) //New timer >=2 | Old timer >=1
        {
            timer = 0;
            time += 1;
        }
    }

    public void damageCount()
    {
        if (
            (Math.Round(enemyOne.position.x) == Math.Round(player.position.x) & Math.Round(enemyOne.position.y) == Math.Round(player.position.y)) ||
            (Math.Round(enemyTwo.position.x) == Math.Round(player.position.x) & Math.Round(enemyTwo.position.y) == Math.Round(player.position.y)) ||
            (Math.Round(enemyThree.position.x) == Math.Round(player.position.x) & Math.Round(enemyThree.position.y) == Math.Round(player.position.y)) ||
            (Math.Round(enemyFour.position.x) == Math.Round(player.position.x) & Math.Round(enemyFour.position.y) == Math.Round(player.position.y)) ||
            (Math.Round(enemyFive.position.x) == Math.Round(player.position.x) & Math.Round(enemyFive.position.y) == Math.Round(player.position.y))
            )
        {
            damage += 1;
        }
    }
}
