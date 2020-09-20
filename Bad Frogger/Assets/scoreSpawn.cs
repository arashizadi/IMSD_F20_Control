using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreSpawn : MonoBehaviour
{
    public Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        _transform.position = new Vector3(Random.Range(-8f, 8f), Random.Range(-8f, 8f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
