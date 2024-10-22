using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float turn = 1.0f;
    Vector3 rot = new Vector3(0.0f, 0.0f, -1.0f);
    // Start is called before the first frame update
    void Start()
    {
        rot.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent <Rigidbody> ();
        Transform t = gameObject.transform;

        if (Input.GetKey ("a")) {

            // float rotateR = Input.GetAxis ("Horizontal");
            
            t.Rotate (0.0f, turn, 0.0f);
            rot = new Vector3 (-turn, 0.0f, 0.0f);
            rot.Normalize();
        }

        if (Input.GetKey("space")) {
            rb.AddForce (rot * 10);
        }
    }
}
