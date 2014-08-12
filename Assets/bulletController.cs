using UnityEngine;
using System.Collections;

public class bulletController : MonoBehaviour {

	private Vector2 velocity;
	private bool collided;
	
	

	// Use this for initialization
	void Start () {
		velocity = new Vector2(0, 10);
	
	}

	void OnCollisionEnter2D(Collision2D collider)
	{
		collided = true;		
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		gameObject.rigidbody2D.velocity = velocity;	
		if (collided) 
		{			
			this.gameObject.SetActive(false);
			Destroy (this.gameObject);	
		}
	}
}
