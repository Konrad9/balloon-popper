using UnityEngine;
using System.Collections;

public class laserController : MonoBehaviour {

	private Vector2 velocity; 

	// Use this for initialization
	void Start () {

		velocity = new Vector2(0, -3.0f); 
		Destroy(gameObject, 10.0f);
	}
	
	// Update is called once per frame
	void Update () {
			gameObject.transform.rigidbody.velocity = velocity;
	}
}
