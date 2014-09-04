using UnityEngine;
using System.Collections;

public class spaceGameController : MonoBehaviour {

	public GameObject enemy;
	private Vector3 enemyStartPosition;
	private float enemySpawnTimer; 
	private float enemyWait; 
	private float randomYSpawnPos; 
	private float randomXSpawnPos; 
	
	// Use this for initialization
	void Start () {
		enemyStartPosition = new Vector3(0,7,-2);
		enemyWait = 2.5f; 
		enemySpawnTimer = 2.0f; 
	}
	
	// Update is called once per frame
	void Update () {
		if ((enemySpawnTimer -= Time.deltaTime) <= 0)
		{
			randomXSpawnPos = Random.Range(-3, 3);
			randomYSpawnPos = Random.Range(6, 9);
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