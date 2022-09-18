using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
	// Start is called before the first frame update


	[SerializeField] public float knoknockOutPercent;

	//Shooting related
	[SerializeField] public Bullet bullet;
	[SerializeField] public IceBullet ice;
	[SerializeField] public FireBullet fire;
	[SerializeField] public LaserSword laser;

	//fire rate
	[SerializeField] public float msBetweenShots = 250;
	// the speed at which the bullet will leave the gun
	[SerializeField] float gunVelocity = 1;
	float nextShotTime;

	public string explosionTag;
	public string collectibleTag;
	public float damage;
	public float knockbackForce;

	public GameMaster gameMaster;

	void Start()
	{
		if (gameMaster == null)
        {
			gameMaster = GameObject.FindGameObjectWithTag("gameMaster").GetComponent<GameMaster>();
        }
		knoknockOutPercent = 0;
	}


	// Update is called once per frame
	void Update()
	{

	}
	public void Shoot(int bulletType)
    {
		if (Time.time > nextShotTime)
		{
			if(bulletType == 2)
            {
				nextShotTime = Time.time + msBetweenShots / 1000;
				FireBullet fireBul = Instantiate(fire, transform.position, transform.rotation);

				fireBul.Setspeed(gunVelocity);
			}
			else if(bulletType == 3)
            {
				nextShotTime = Time.time + msBetweenShots / 1000;
				IceBullet iceBul = Instantiate(ice, transform.position, transform.rotation);

				iceBul.Setspeed(gunVelocity);
			}
			else
            {
				nextShotTime = Time.time + msBetweenShots / 1000;
				Bullet newbullet = Instantiate(bullet, transform.position, transform.rotation);

				newbullet.Setspeed(gunVelocity);
			}
		}
	}

	public void TakeHit(float damage)
	{
		knoknockOutPercent += damage;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Tilemap")
        {
			Debug.Log(gameObject.layer);
			gameMaster.EndGame(gameObject.layer);
        }
    }
}


