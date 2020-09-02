using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformTwo : MonoBehaviour
{
    public Transform initTransformTwo;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    DateTime initTime = DateTime.Now;
    initTransformTwo.position = new Vector3(-14 + UnityEngine.Random.Range(0.0f, -0.010f), UnityEngine.Random.Range(0.0f, 5f), initTime.Second);
    }
}
