using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class enemyController : MonoBehaviour {

	private float reloadTimer;
	private float reloadDuration;

	private float playerLocation; 
	private bool hitWall; 

	private Vector2 velocity; 

	private float crazyIvan; 

	// Use this for initialization
	void Start () {
		reloadTimer = 0; 
		reloadDuration = 1.75f;

		crazyIvan = Random.Range(0, 15);

		hitWall = false;

		velocity = new Vector2(2.0f, -.50f);
	}
	
	// Update is called once per frame
	void Update () {
		//gameObject.transform.rigidbody2D.AddForce(new Vector2(1.0f, -1.0f)); 
		Debug.Log(crazyIvan);
		if ((crazyIvan -= Time.deltaTime) <= 0)
		{
			crazyIvan =  Random.Range(0, 10);
			velocity.x *= -1; 
		}
		gameObject.transform.rigidbody2D.velocity = velocity;
	}

	private void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "wall")
		velocity.x *= -1; 
	}
}


//how long between ships
//how many hits to destroy the ship 
//how many ships before mini-boss, boss
//how many hits to destroy player
//are enemy ships shielded
//who has fire and forget, who has tracked shots, who has instant-kill lazers 
//crazyIvan will randomly reverse X velocity independently of the walls 











