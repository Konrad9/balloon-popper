using UnityEngine;
using System.Collections;

public class balloonController : MonoBehaviour {

	private GameObject mainCamera; 
	
	// Use this for initialization
	void Start () {
		mainCamera = GameObject.Find("Main Camera");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision)
	{	
		movementController cameraScript = mainCamera.GetComponent(typeof(movementController)) as movementController;
		cameraScript.increaseScore(collision.collider.gameObject.tag);
		this.gameObject.SetActive(false);
		Destroy(this.gameObject);
	}

}
