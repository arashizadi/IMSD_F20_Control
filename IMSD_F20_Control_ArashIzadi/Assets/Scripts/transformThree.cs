using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformThree : MonoBehaviour
{
    public Transform initTransformThree;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        initTransformThree.position = new Vector3(4 + UnityEngine.Random.Range(0.0f, 0.04f), UnityEngine.Random.Range(0.0f, 0.05f), 0);
    }
}
