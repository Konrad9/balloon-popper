using UnityEngine;
using System.Collections;

public class balloonController : MonoBehaviour {

	public GameObject go_particleEffect;
	public TextMesh textObject;
	private bool reverseEngines = false; 
	private Vector2 reverse;

	// Use this for initialization
	void Start () {
		reverse = new Vector2(0.0f, -10.0f);

	}

	void OnCollisionEnter2D(Collision2D collider)
	{
		if (collider.gameObject.tag == "wall") {
			ContactPoint2D contact = collider.contacts[0];
			Vector2 pos = contact.point; 
			Instantiate(go_particleEffect, pos, Quaternion.identity);

		}

		if (collider.gameObject.tag == "bullet") 
		{
			////textobject text text text
			/// 
		}

		if (collider.gameObject.tag == "floor") 
		{

			Destroy(gameObject);		
		}

	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.tag == "roof") 
		{
			reverseEngines = true;
		}


	}
	
	// Update is called once per frame
	void Update () {
		if (reverseEngines == true) 
		{
			gameObject.rigidbody2D.AddForce(reverse);
			Debug.Log(gameObject.rigidbody2D.velocity.y);

			if (gameObject.rigidbody2D.velocity.y <= -3.0f)
			{
				reverseEngines = false;
			}
		}
	}
}
