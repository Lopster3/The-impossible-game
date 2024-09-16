using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1;
    public float jumpt = 0;
    public float jumph = 10;

    void Update()
    {
        if (jumpt<=1)
        {
            jumpt += 0.5f * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.W)) //move forward
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)) //move backwards
        {
            transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)) //move left
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.D)) //move right
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            if (jumpt >= 1)
            {
                transform.position += new Vector3(0, jumph * Time.deltaTime, 0);
                jumpt -= 1;
            }
           
        }
    }
}
