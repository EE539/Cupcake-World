using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelTurn : MonoBehaviour
{
    private static float speed = 45.0f;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.left, Time.deltaTime * speed * 5 * verticalInput);
    }
}

