using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PugPlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float thrust;
    public AudioSource source;
    public AudioClip clip;
    
    [SerializeField] private Player playerScript;
    private int nextBullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up * thrust);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.AddForce(-transform.up * thrust);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.AddForce(transform.right * thrust);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddForce(-transform.right * thrust);
        }
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            source.PlayOneShot(clip);
            playerScript.Shoot(nextBullet);
            nextBullet = 1;

        }
    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == playerScript.explosionTag)
        {
            // Take Damage
            playerScript.TakeHit(playerScript.damage);
            Debug.Log(playerScript.knoknockOutPercent);

            // Apply knockback force
            KnockBack(col.transform.position);
        }
        if(col.gameObject.tag == "Tilemap")
        {
            SceneManager.LoadScene("FrogVictory");
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Pug_Fire")
        {
            Destroy(col.gameObject);
            // Change Next Bullet to Fire Extinguisher
            nextBullet = 2;
        }
        if (col.gameObject.tag == "Pug_Ice")
        {
            Destroy(col.gameObject);
            // Change Next Bullet to Ice Cube
            nextBullet = 3;

        }
        if (col.gameObject.tag == "Pug_Laser")
        {
            Destroy(col.gameObject);
            // Instantiate Laser Sword
            Instantiate(playerScript.laser);
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
