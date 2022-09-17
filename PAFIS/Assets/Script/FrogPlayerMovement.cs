using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogPlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float thrust;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(transform.up * thrust);
            Debug.Log("up");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(-transform.up * thrust);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(transform.right * thrust);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(-transform.right * thrust);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
}
