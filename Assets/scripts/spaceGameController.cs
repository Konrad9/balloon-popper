using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class spaceGameController : MonoBehaviour {

	public GameObject enemy;
	private Vector3 enemyStartPosition;
	private float enemySpawnTimer; 
	private float enemyWait; 
	private float randomYSpawnPos; 
	private float randomXSpawnPos; 
	private float score; 
	private List<float> enemyTypes;
	
	// Use this for initialization
	void Start () {
		enemyStartPosition = new Vector3(0,7,-2);
		enemyWait = 1.5f; 
		enemySpawnTimer = 0.4f; 
		score = 0; 
		enemyTypes = new List<float>();
		for (float i = 0; i < 5; i++)
		{
			///populate a list of enemy types
			/// this will be a more real thing later 
			enemyTypes.Add (i + 1f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if ((enemySpawnTimer -= Time.deltaTime) <= 0)
		{
			randomXSpawnPos = UnityEngine.Random.Range(-3, 3);
			randomYSpawnPos = UnityEngine.Random.Range(6, 9);
			spawnNewEnemy();
			enemySpawnTimer = enemyWait;
		}



	}
	void OnCollisionEnter(Collision collider)
	{
		
	}

	public void addToScore(int destroyedEnemy)
	{
		///score adds 100 * enemy multiplier
		score += enemyTypes[destroyedEnemy] * 100f; 

		scoreController _scoreController = GetComponent<GUIText>(scoreController);
		_scoreController.displayScore(score); 
	}
	
	private float newRandomFloat()
	{
		return (UnityEngine.Random.Range (-8, 8));
	}
	
	public void spawnNewEnemy()
	{		
		Instantiate (enemy, enemyStartPosition, Quaternion.identity);
	}
	
}