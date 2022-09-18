using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
	// Start is called before the first frame update


	[SerializeField] public float knoknockOutPercent;

	//Shooting related
	[SerializeField] public Bullet bullet;
	//fire rate
	[SerializeField] public float msBetweenShots = 250;
	// the speed at which the bullet will leave the gun
	[SerializeField] float gunVelocity = 1;
	float nextShotTime;

	public string explosionTag;
	public string collectibleTag;
	public float damage;
	public float knockbackForce;

	void Start()
	{
		knoknockOutPercent = 0;
	}


	// Update is called once per frame
	void Update()
	{ 
		if (Input.GetMouseButton(0))
		{
			Shoot(bullet);
		}

	}

	public void Shoot(Bullet shootingBullet)
	{
		if (Time.time > nextShotTime)
		{
			nextShotTime = Time.time + msBetweenShots / 1000;
			Bullet newbullet = Instantiate(shootingBullet, transform.position, transform.rotation);

			newbullet.Setspeed(gunVelocity);

		}

	}

	public void TakeHit(float damage)
	{
		knoknockOutPercent += damage;
	}
}


