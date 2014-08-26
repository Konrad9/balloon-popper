using UnityEngine;
using System.Collections;

public class scrollCreator : MonoBehaviour {

	public GameObject scroller;
	private Vector3 newScrollerPosition;
	private bool newBackgroundSpawned; 

	// Use this for initialization
	void Start () {
		newScrollerPosition = new Vector3(0f, 13f, 0f);
		newBackgroundSpawned = false; 
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y <= -2.5)
		{
			spawnNewBackground();
		}
		if (gameObject.transform.position.y <= -13.5)
		{
			Destroy(gameObject);
		}
	}
	
	void spawnNewBackground()
	{
		if (!newBackgroundSpawned)
		{
			Instantiate(scroller, newScrollerPosition, Quaternion.identity);
			newBackgroundSpawned = true; 
		}
	}
}
