using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, speed * Time.deltaTime);
        }
        
                if(Input.GetKey(KeyCode.S))
	        {
	            rb.AddForce(0, 0, -speed * Time.deltaTime);
        }
        
                if(Input.GetKey(KeyCode.D))
	        {
	            rb.AddForce(speed * Time.deltaTime, 0, 0);
        }
        
                if(Input.GetKey(KeyCode.A))
	        {
	            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }
    }
}
