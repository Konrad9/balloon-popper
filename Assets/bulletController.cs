using UnityEngine;
using System.Collections;

public class bulletController : MonoBehaviour {

	private Vector2 velocity;
	private bool collided;
	public GameObject sploder;

	// Use this for initialization
	void Start () {
		velocity = new Vector2(0, 10);
		gameObject.rigidbody2D.velocity = velocity;	
		Destroy (gameObject, 10.0f);
	}

	void OnCollisionEnter2D(Collision2D collider)
	{
		Destroy (gameObject);
		Instantiate(sploder, gameObject.transform.position, Quaternion.identity); 

	}

	
	// Update is called once per frame
	void Update () 
	{

	}
}
