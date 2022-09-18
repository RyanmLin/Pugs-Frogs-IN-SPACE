using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{


    [SerializeField] public float speed;
    float duration = 5;


    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
        float moveDistance = speed * Time.deltaTime;
        //CheckCollisions(moveDistance);
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }

    public void Setspeed(float newSpeed)
    {
        speed = newSpeed;
     
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("enter");
        if (collision.gameObject.layer == 31)
        {
            GameObject.Destroy(collision.gameObject);
            GameObject.Destroy(gameObject);
        }
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Debug.Log("enter");
    //    if (collision.tag == "Bullet")
    //    {
    //        GameObject.Destroy(collision);
    //        GameObject.Destroy(gameObject);
    //    }
    //}

}


