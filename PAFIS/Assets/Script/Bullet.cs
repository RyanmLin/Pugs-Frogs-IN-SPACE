using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{


    Animator animator;
    [SerializeField] public float speed;
    public float duration = 70;
    float exlopsionDelay = 2;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
        if (duration < 0)
        {
            animator.SetBool("Idling", true);
            speed = 0;
            exlopsionDelay--;
        }

        duration--;
    }

    public void Setspeed(float newSpeed)
    {
        speed = newSpeed;
     
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
  
        if (collision.gameObject.tag == "Bullet")
        {
            animator.SetBool("Exploding", true);
            StartCoroutine(explosionDelayer(collision));
                
        }
    }



   IEnumerator explosionDelayer(Collision2D collision)
    {
        yield return new WaitForSeconds(0.6f);
        GameObject.Destroy(gameObject);
    }

}


