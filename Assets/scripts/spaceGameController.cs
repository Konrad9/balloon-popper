using UnityEngine;
using System.Collections;

public class spaceGameController : MonoBehaviour {

	public GameObject enemy;
	private Vector3 enemyStartPosition;
	private float enemySpawnTimer; 
	private float enemyWait; 
	
	// Use this for initialization
	void Start () {
		enemyStartPosition = new Vector3(0,7,-2);
		enemyWait = 1.5f; 
		enemySpawnTimer = 2.0f; 
	}
	
	// Update is called once per frame
	void Update () {
		if ((enemySpawnTimer -= Time.deltaTime) <= 0)
		{
			spawnNewEnemy();
			enemySpawnTimer = enemyWait;
		}
	}
	void OnCollisionEnter2D(Collision2D collider)
	{
		
	}
	
	private float newRandomFloat()
	{
		return (Random.Range (-8, 8));
	}
	
	public void spawnNewEnemy()
	{		
		Instantiate (enemy, enemyStartPosition, Quaternion.identity);
	}
	
}