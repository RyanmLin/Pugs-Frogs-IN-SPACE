using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
	// Start is called before the first frame update


	[SerializeField] public float knoknockOutPercent;
	void Start()
	{
		knoknockOutPercent = 0;
	}


	// Update is called once per frame
	void Update()
	{
		TakeHit(1);
	}




	public void TakeHit(float damage)
	{
		knoknockOutPercent += damage;
	}
}


