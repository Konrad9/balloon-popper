using UnityEngine;
using System.Collections;

public class balloonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter2D(Collision2D collider)
	{
		Debug.Log (collider.gameObject.tag);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
