using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class enemyController : MonoBehaviour {

	private float reloadTimer;
	private float reloadDuration;

	private bool moveDown;
	private float movedDown; 

	private float playerLocation; 
	private bool hitWall; 

	private Vector2 velocity; 

	private float crazyIvan; 
	private float xVelocity;

	private Vector3 laserOffsetPosition; 

	public GameObject laserBeam; 

	public GameObject gameController; 

	private spaceGameController _spaceGameController; 

	// Use this for initialization
	void Start () {
		movedDown = 0;
		moveDown = false;
		reloadTimer = 5; 
		reloadDuration = 3.75f;
		xVelocity = 4.0f;

		crazyIvan = Random.Range(0, 15);

		hitWall = false;

		velocity = new Vector2(xVelocity, 0);
		gameObject.transform.rigidbody.velocity = velocity;


		gameController = GameObject.Find ("Main Camera");
	} 
	
	// Update is called once per frame
	void Update () {
		//gameObject.transform.rigidbody2D.AddForce(new Vector2(1.0f, -1.0f)); 
		//Debug.Log(crazyIvan);
		/*if ((crazyIvan -= Time.deltaTime) <= 0)
		{
			crazyIvan =  Random.Range(0, 10);
			velocity.x *= -1; 
			gameObject.rigidbody.velocity = velocity; 
		}*/

		if (gameObject.rigidbody.velocity.y < 0)
		{
			velocity.y += 4; 
			gameObject.rigidbody.velocity = velocity; 
			//Debug.Log(velocity.y);
		}

		if ((reloadTimer -= Time.deltaTime) <= 0)
		{
			laserOffsetPosition = gameObject.transform.position;
			laserOffsetPosition.y += .01f;
			fireWeapon();
			reloadTimer = reloadDuration;
		}

		if (moveDown)
		{
			if (movedDown++ >= 10)
			{
				moveDown = false; 
				movedDown = 0; 
			}
			transform.Translate (new Vector3(0, -0.1f, 0));
		}
	}

	private void fireWeapon()
	{
		Instantiate(laserBeam, laserOffsetPosition, Quaternion.identity );
	}

	private void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "wall"){
			velocity.x *= -1; 
			if (gameObject.transform.position.y >= -2.5)
				moveDown = true;
				//transform.Translate(new Vector3(0, -1.0f, 0)); 
			gameObject.rigidbody.velocity = velocity; 
		}
		if (collider.tag =="enemy")
		{
			Destroy(gameObject);
		}

	}
	private void OnCollisionEnter(Collision collider)
	{
		//Debug.Log(collider.gameObject.tag);
		if (collider.gameObject.tag != "wall")
		{
			Destroy(gameObject);
		}

		if (collider.gameObject.tag == "bullet")
		{
			GameObject camera = GameObject.FindWithTag("MainCamera");
			camera.GetComponent<spaceGameController>().addToScore(1);
			
			Destroy(gameObject);
		}
	}
}


//how long between ships
//how many hits to destroy the ship 
//how many ships before mini-boss, boss
//how many hits to destroy player
//are enemy ships shielded
//who has fire and forget, who has tracked shots, who has instant-kill lazers 
//crazyIvan will randomly reverse X velocity independently of the walls 











