using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions: MonoBehaviour
{
    public GameObject p1, p2;
    static public int x = 0;
    public GameObject[] p1wheel, p2wheel;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        if (other.gameObject==p1) 
        {
            p2.transform.position = new Vector3(50.411f, 3.2036f, 211.529f);
            p1.transform.position = new Vector3(89, 5.504193f, 25.0781f);
            p1.transform.rotation = Quaternion.Euler(0, -43.487f, 0);
            p1.GetComponent<PlayerController>().enabled = false;
            for(int i = 0; i < p1wheel.Length; i++)
            {
                p1wheel[i].GetComponent<WheelTurn>().enabled = false;
            }
            x = 1;
        }
        else if(other.gameObject == p2)
        {
            p1.transform.position = new Vector3(-25.411f, -3.2036f, 211.529f);
            p2.transform.position = new Vector3(89, 10.504193f, 25.0781f);
            p2.transform.rotation = Quaternion.Euler(0, -43.487f, 0);
            p2.GetComponent<PlayerController_2>().enabled = false;
            for (int i = 0; i < p2wheel.Length; i++)
            {
                p2wheel[i].GetComponent<WheelTurn>().enabled = false;
            }
            x = 2;
        }
    }
}
