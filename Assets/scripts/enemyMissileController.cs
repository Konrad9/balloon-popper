using UnityEngine;
using System.Collections;

public class enemyMissileController : MonoBehaviour {
	private float yVelocity; 
	public GameObject player; 
	private Vector3 fireTrajectory; 
	private Vector3 velocity; 

	// Use this for initialization
	void Start () {
		velocity = new Vector3(0, 4, 0); 
		player = GameObject.Find ("player");
	}
	
	// Update is called once per frame
	void Update () {
		///compute basic trajectory to player, go there, blow up if hit by bullet

		fireTrajectory = (player.transform.position - gameObject.transform.position).normalized;
		gameObject.transform.LookAt(player.transform);
		gameObject.rigidbody.position += fireTrajectory * 4.0f * Time.deltaTime; 
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
