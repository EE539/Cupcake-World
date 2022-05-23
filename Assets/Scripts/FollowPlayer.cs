using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -8);
    private int change = 0;
    private Vector3 rotateValue;
    // Start is called before the first frame update
    void Start()
    {
        rotateValue = new Vector3(15.223f, 1.003f, -0.166f);
        transform.eulerAngles = rotateValue;
    }

    // Update is called once per frame
    void Update()
    {
        //Offset the camera behind the player by adding to the player's position
        if (Input.GetKeyDown(KeyCode.C) && change == 0)
        {
            offset = new Vector3(24.06f, 4.3f, 0);
            rotateValue = new Vector3(-1.011f, -82.659f, 2.502f);
            transform.eulerAngles = rotateValue;
            change = 1;
        }
        else if (Input.GetKeyDown(KeyCode.C) && change == 1)
        {
            offset = new Vector3(0, 5, -8);
            rotateValue = new Vector3(15.223f, 1.003f, -0.166f);
            transform.eulerAngles = rotateValue;
            change = 0;
        }
        if(DetectCollisions.x == 1)
        {
            offset = new Vector3(-15.42f, 1.6f, -0.68f);
            rotateValue = new Vector3(4.161f, 101.734f, - 3.353f);
            transform.eulerAngles = rotateValue;
        }
        else if(DetectCollisions.x == 2)
        {
            offset = new Vector3(-15.42f, 1.6f, 0.68f);
            rotateValue = new Vector3(4.161f, 101.734f, -3.353f);
            transform.eulerAngles = rotateValue;
        }
        transform.position = player.transform.position + offset;
    }
}
