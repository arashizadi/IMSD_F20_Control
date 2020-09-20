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
    private float timer;
    int time;
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
}
