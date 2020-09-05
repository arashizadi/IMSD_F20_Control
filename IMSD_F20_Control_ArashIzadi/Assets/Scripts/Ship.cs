using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public Transform transformShip;
    public bool leftToRightDirection;
    // Start is called before the first frame update
    void Start()
    {
        leftToRightDirection = true;
        transformShip.position = new Vector3(0, Random.Range(4f, 8f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (leftToRightDirection && transformShip.position.x >= 33)
        {
            transformShip.position =  new Vector3(33, Random.Range(4.00f, 8.00f), 0);
            leftToRightDirection = false;
            Debug.Log("The Y: " + transformShip.position.y);
            Debug.Log(leftToRightDirection);
        }
        if (!leftToRightDirection && transformShip.position.x <= -33)
        {
            transformShip.position = new Vector3(-33, Random.Range(4.00f, 8.00f), 0);
            leftToRightDirection = true;
            Debug.Log("The Y: " + transformShip.position.y);
            Debug.Log(leftToRightDirection);
        }
        if (leftToRightDirection)
            transformShip.position += new Vector3(0.01f, 0, 0);
        else
            transformShip.position -= new Vector3(0.01f, 0, 0);
    }
}
