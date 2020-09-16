using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class EnemyMovement : MonoBehaviour
{
    private float speed;
    public float _speed;
    private float timer;
    public Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.75f;
        _speed = 1f;
        speed = Random.Range(1,5) * _speed;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            timer = 0;
            _transform.position += new Vector3(Random.Range(-5.00f, 5.00f), 0, 0) * speed;
        }
        if (_transform.position.x > 10 || _transform.position.x < -10)
            _transform.position = new Vector3(0, 0, 0);

    }
}
