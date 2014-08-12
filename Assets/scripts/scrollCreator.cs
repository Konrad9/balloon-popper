using UnityEngine;
using System.Collections;

public class scrollCreator : MonoBehaviour {

	public GameObject scroller;
	private Vector3 newScrollerPosition;

	// Use this for initialization
	void Start () {
		newScrollerPosition = new Vector3(0f, 12.5f, 0f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter()
	{
		Instantiate(scroller, newScrollerPosition, Quaternion.identity);
		
	}
}
