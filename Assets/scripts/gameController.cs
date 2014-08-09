using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {

	public GameObject balloon;
	private Vector2 randomBalloonPos;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D(Collision2D collider)
	{
		Debug.Log ("Impact!");
		if (collider.gameObject.tag == "balloon")
		{
			spawnNewBall();
		}
	}

	private float newRandomFloat()
	{
		return (Random.Range (-8, 8));
	}

	public void spawnNewBall()
	{
		randomBalloonPos = new Vector2 (newRandomFloat(), 7.0f);
		Instantiate (balloon, randomBalloonPos, Quaternion.identity);
	}
		
}
