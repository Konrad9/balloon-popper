using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class enemyMissileController : MonoBehaviour {
	private float yVelocity; 
	public GameObject player; 
	private Vector3 fireTrajectory; 
	private Vector3 velocity; 
	private List<Vector3> playerLocationList;

	// Use this for initialization
	void Start () {
		velocity = new Vector3(0, 4, 0); 
		player = GameObject.Find ("player");
		playerLocationList = new List<Vector3>(); 
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "bullet")
		{
			Destroy(gameObject); 
		}
	}

	// Update is called once per frame
	void Update () {
		///compute basic trajectory to player, go there, blow up if hit by bullet
		/// 
		if (playerLocationList.Count >= 25)
		{
			playerLocationList.Add (player.transform.position);
			playerLocationList.RemoveAt(0);
		}
		else
		{
			playerLocationList.Add (player.transform.position);
		}



		fireTrajectory = (playerLocationList[0] - gameObject.transform.position).normalized;
		gameObject.transform.LookAt(player.transform);
		//gameObject.rigidbody.position += fireTrajectory * 4.0f * Time.deltaTime; 
		gameObject.rigidbody.AddForce(fireTrajectory * 5);
	}
}
/*

void Start()
{
	movementDirection = (pathPoints[currentPathIndex].transform.position - transform.position).normalized;
}

// Update is called once per frame
void Update ()
{	
	//movement code
	transform.position += movementDirection*speed*Time.deltaTime;
}*/
