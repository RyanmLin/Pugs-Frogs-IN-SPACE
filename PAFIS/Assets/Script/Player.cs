using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
	// Start is called before the first frame update


	[SerializeField] public float knoknockOutPercent;


	[SerializeField] public Bullet bullet;
	//Shooting related
	//fire rate
	[SerializeField] public float msBetweenShots = 250;
	// the speed at which the bullet will leave the gun
	[SerializeField] float gunVelocity = 1;

	float nextShotTime;

	void Start()
	{
		knoknockOutPercent = 0;
	}


	// Update is called once per frame
	void Update()
	{
		TakeHit(1);
		if (Input.GetMouseButton(0))
		{
			Shoot(bullet);
		}
		

	}




	public void TakeHit(float damage)
	{
		knoknockOutPercent += damage;
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
}


