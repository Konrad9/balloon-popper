using UnityEngine;
using System.Collections;

public class scrollingBackground : MonoBehaviour {

	private Vector2 positionMover; 
	// Use this for initialization
	void Start () {
		positionMover = new Vector2();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(positionMover);
		positionMover = gameObject.transform.position;
		positionMover.y -= 0.01f; 
		gameObject.transform.position = positionMover; 
	}
}
