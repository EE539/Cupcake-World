using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_2 : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    //public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get player input
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down, Time.deltaTime * turnSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed);
        }
    }
}
