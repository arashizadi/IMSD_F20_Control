using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using Random = System.Random;

public class EnemyMovement : MonoBehaviour
{
    private bool leftToRightDirection;
    private float speed;
    public float _speed;
    private float timer;
    public Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.75f;
        _speed = 1f;
        speed = UnityEngine.Random.Range(1,5) * _speed;
        { //New
            var restoreYPosition = _transform.position.y;
            var restoreZPosition = _transform.position.z;
            _transform.position = new Vector3(UnityEngine.Random.Range(-4.00f, 4.00f), restoreYPosition, restoreZPosition);
        }

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2) //New timer >=2 | Old timer >=1
        {
            Random rNG = new Random(); //New
            timer = 0;
            if (rNG.Next(100) < 50) //New
                leftToRightDirection = true;
            else
                leftToRightDirection = false;



            //_transform.position += new Vector3(UnityEngine.Random.Range(-5.00f, 5.00f), 0, 0) * speed;
        }
        if (leftToRightDirection)
            _transform.position += new Vector3(0.01f, 0, 0);
        else
            _transform.position -= new Vector3(0.01f, 0, 0);

        if (_transform.position.x > 10 || _transform.position.x < -10)
        {
            var restoreYPosition = _transform.position.y;
            var restoreZPosition = _transform.position.z;
            _transform.position = new Vector3(0, restoreYPosition, restoreZPosition);

        }

    }
}
