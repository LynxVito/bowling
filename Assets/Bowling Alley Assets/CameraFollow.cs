using System.Collections;
using System.Collections.Generic;
using UnityEditor.AnimatedValues;
using UnityEngine;
using UnityEngine.UIElements;


public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 offset;
    public GameObject ball;
    Vector3 newPos;
    void Start()
    {
        offset = transform.position - ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newPos = ball.transform.position + offset;
        transform.position = newPos;
    }
}
