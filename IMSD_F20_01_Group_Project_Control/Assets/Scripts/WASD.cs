using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASP : MonoBehaviour
{
    public Transform _transform;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;

    }

    // Update is called once per frame
    void Update()
    {
        KeyMovement();
    }
    private void KeyMovement()
    {
        if (Input.GetKey(KeyCode.W)) //UP
        {
            _transform.position += new Vector3(0, 0.5f, 0) * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.S)) //Down
        {
            _transform.position += new Vector3(0, -0.3f, 0) * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.D)) //Right
        {
            _transform.position += new Vector3(0.25f, 0, 0) * speed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.A)) //Left
        {
            _transform.position += new Vector3(-0.25f, 0, 0) * speed * Time.deltaTime;

        }

    }
}


