using UnityEngine;
using System.Collections;

public class balloonController : MonoBehaviour {

	public GameObject go_particleEffect;
	public TextMesh textObject;

	// Use this for initialization
	void Start () {

	}

	void OnCollisionEnter2D(Collision2D collider)
	{
		Debug.Log (collider.gameObject.tag);
		if (collider.gameObject.tag == "wall") {
			Instantiate(go_particleEffect, gameObject.transform.position, Quaternion.identity);
		}

		if (collider.gameObject.tag == "bullet") {
			////textobject text text text
			/// 
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
