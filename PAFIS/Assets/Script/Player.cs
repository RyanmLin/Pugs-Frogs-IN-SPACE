using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
	// Start is called before the first frame update


	[SerializeField] public float knoknockOutPercent;
	public string explosionTag;
	public float damage;
	public float knockbackForce;

	void Start()
	{
		knoknockOutPercent = 0;
	}


	// Update is called once per frame
	void Update()
	{

	}

	public void TakeHit(float damage)
	{
		knoknockOutPercent += damage;
	}
}


