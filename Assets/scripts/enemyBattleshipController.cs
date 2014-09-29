using UnityEngine;
using System.Collections;

public class enemyBattleshipController : MonoBehaviour {
	public GameObject missile;
	public GameObject laserBeam; 


	private Vector3 velocity; 

	private float xVelocity;
	private float yVelocity; 
	private float missileReloadTimer;
	private float missileReloadWait;
	private float laserReloadTimer;
	private float laserReloadWait;
	private float hp; 
	private float shieldHP; 



	// Use this for initialization
	void Start () {
		///slightly more than 1/2 basic enemy speed
		xVelocity = 2.5f; 
		yVelocity = 1.5f; 
		laserReloadWait = 1.5f;
		missileReloadWait = 5.0f;
		hp = 100f;
		shieldHP = 50f;
		velocity = new Vector3(xVelocity, yVelocity, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {

		gameObject.rigidbody.velocity = velocity; 

		if (gameObject.transform.position.y < 9)
		{
			velocity.y = yVelocity; 
		}

		if (gameObject.transform.position.y > 16)
		{
			velocity.y = - yVelocity; 
		}

		if ((missileReloadTimer += Time.deltaTime) >= missileReloadWait)
		{
			fireMissile();
		}

		if ((laserReloadTimer += Time.deltaTime) >= laserReloadWait)
		{
			fireLaser();
		}
	}

	private void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "wall")
		{
			velocity.x *= -1; 
			Debug.Log ("hitwall");
			gameObject.rigidbody.velocity = new Vector3(xVelocity, gameObject.rigidbody.velocity.y, 0.0f);
		}
	}

	private void fireMissile()
	{
		Instantiate(missile, gameObject.transform.position, Quaternion.identity);
		missileReloadTimer = 0;
	}

	private void fireLaser()
	{
		Instantiate(laserBeam, gameObject.transform.position, Quaternion.identity);
		laserReloadTimer = 0; 
	}
}
