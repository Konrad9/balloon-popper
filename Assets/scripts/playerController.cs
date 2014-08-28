using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class playerController : MonoBehaviour {

	public GameObject bullet;
	private Vector3 firePosition;
	Vector3 offset;


	// Use this for initialization
	void Start () {
		offset = new Vector3 (0f, 0.8f, 0.0f);
		firePosition = gameObject.transform.position; 
		firePosition += offset;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow)) 
		{
			gameObject.transform.position = new Vector3(gameObject.transform.position.x + .1f, (gameObject.transform.position.y), -2.0f); 
		}

		if (Input.GetKey(KeyCode.LeftArrow)) 
		{
			gameObject.transform.position = new Vector3(gameObject.transform.position.x - .1f, (gameObject.transform.position.y), -2.0f); 
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			firePosition = gameObject.transform.position; 
			firePosition += offset;
			fire();

		}

	}


	void fire()
	{
		Instantiate (bullet, firePosition, Quaternion.identity);
	}
}
