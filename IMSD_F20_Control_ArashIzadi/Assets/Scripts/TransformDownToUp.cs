using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformDownToUp : MonoBehaviour
{
    public Transform _transform;
    public float speed;
    // Start is called before the first frame update

    private void Start()
    {
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        _transform.position += new Vector3(0, 0.1f, 0) * speed * Time.deltaTime;
        //_transform.position += new Vector3(0, 0.1f, 0) * speed * Random.Range(1.00f, 2.00f) * Time.deltaTime;

    }
}
