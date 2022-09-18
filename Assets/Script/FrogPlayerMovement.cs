using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogPlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float thrust;
    public AudioSource source;
    public AudioClip clip;
  
    [SerializeField] private Player playerScript;
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
            source.PlayOneShot(clip);
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == playerScript.explosionTag)
        {
            Debug.Log("ouch");
            // Take Damage
            playerScript.TakeHit(playerScript.damage);

            // Apply knockback force
            KnockBack(col.transform.position);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Frog_Fire")
        {
            Destroy(col.gameObject);
            // Change Next Bullet to Fire Extinguisher
        }
        if (col.gameObject.tag == "Frog_Ice")
        {
            Destroy(col.gameObject);
            // Change Next Bullet to Ice Cube
        }
        if (col.gameObject.tag == "Frog_Laser")
        {
            Destroy(col.gameObject);
            // Instantiate Laser Sword
        }
    }

    private void KnockBack(Vector3 explosionCenter)
    {
      
        // Solve Direction
        var direction = explosionCenter - transform.position;
        // Solve Force
        var force = 1 + playerScript.knoknockOutPercent * playerScript.knockbackForce;
        // Apply Force
        rb.AddForce(direction * force);
    }

}
