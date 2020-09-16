﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASP : MonoBehaviour
{
    public Transform _transform;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1f;

    }

    // Update is called once per frame
    void Update()
    {
        KeyMovement("W");
        KeyMovement("S");
    }
    private void KeyMovement(string key)
    {
        if (Input.GetKey(KeyCode.W))
        {
            _transform.position += new Vector3(0, 0.05f, 0) * speed * Time.deltaTime;

            if (Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.W))
            {
                _transform.position += new Vector3(0, 0.1f, 0) * speed * Time.deltaTime;

            }
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            _transform.position += new Vector3(0, 0.01f, 0) * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            _transform.position += new Vector3(0, -0.05f, 0) * speed * Time.deltaTime;

            if (Input.GetKey(KeyCode.S) & Input.GetKey(KeyCode.S))
            {
                _transform.position += new Vector3(0, -0.1f, 0) * speed * Time.deltaTime;

            }
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            _transform.position += new Vector3(0, -0.01f, 0) * speed * Time.deltaTime;
        }


    }
}

