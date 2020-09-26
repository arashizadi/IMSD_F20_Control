using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private float time;
    public Transform _transform;
    private float airHeightMax;
    private bool leftToRight;
    private bool lockCD;
    // Start is called before the first frame update
    void Start()
    {
        leftToRight = true;
        lockCD = false;
        airHeightMax = 1000;
        time = 0;

    }

    // Update is called once per frame
    void Update()
    {
        lockCD = true;
        time += Time.deltaTime;
        if (time >= 1 && Input.GetKey(KeyCode.Space))
        {
            for (int i = 1; i < airHeightMax; i++)
            {
                if (leftToRight && lockCD == true)
                    _transform.position += new Vector3(0, 0.005F, 0) * i / airHeightMax;
                if (!leftToRight && lockCD == true)
                    _transform.position -= new Vector3(0, 0.005F, 0) * i / airHeightMax;
                if (i <= 999)
                    lockCD = false;
            }
        }
    }
}

