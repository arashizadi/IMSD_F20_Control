using System;
using UnityEngine;

public class transform : MonoBehaviour
{
    public Transform initTransform;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    DateTime initTime = DateTime.Now;
    initTransform.position = new Vector3(UnityEngine.Random.Range(0.0f, 0.05f), UnityEngine.Random.Range(0.0f, 0.1f), initTime.Millisecond / 10);
    initTransform.rotation = new Quaternion(1000, initTime.Second, initTime.Millisecond, initTime.Millisecond/1000);
    }
}
