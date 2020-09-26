using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private float time;
    public Transform _transform;
    private float airHeightMax;
    private bool phaseAir;
    private bool lockCD;
    // Start is called before the first frame update
    void Start()
    {
        phaseAir = false;
        airHeightMax = 1000;
        time = 0;

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (lockCD == false && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0)))
        {
            for (int i = 1; i < airHeightMax; i++)
            {
                if (!phaseAir)
                    _transform.position += new Vector3(0, 0.005F, 0) * (i / (airHeightMax + 1000));
                if (phaseAir)
                    _transform.position -= new Vector3(0, 0.005F, 0) * (i / (airHeightMax + 1000));
                if (i <= 999)
                    phaseAir = true;
            }
            phaseAir = false;
        }
        else if (lockCD == false && (Input.GetKeyUp(KeyCode.Space) || Input.GetKeyUp(KeyCode.Mouse0)))
        {

        }
    }
}

