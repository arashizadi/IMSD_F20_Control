using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    public Transform capsuleTransform;
    public float speed;
    private float timer;
    void Start()
    {
        timer = 0;
        speed = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            timer = 0;
            capsuleTransform.position += new Vector3(Random.Range(-2.00f, 2.00f), 0, Random.Range(0.50f, 0.50f)) * speed;
        }
    }
}
