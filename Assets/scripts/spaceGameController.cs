using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class spaceGameController : MonoBehaviour {

	public GameObject p_basicEnemy;
	private Vector3 enemyStartPosition;
	private float basicEnemySpawnTimer; 
	private float basicEnemySpawnWaitTime; 
	private float randomYSpawnPos; 
	private float randomXSpawnPos; 
	private float score; 
	private float basicEnemySpawnCount; 
	private List<float> enemyTypes;
	public GUIText c; 

	// Use this for initialization
	void Start () {
		enemyStartPosition = new Vector3(0,7,-2);
		basicEnemySpawnWaitTime = 1.5f; 
		basicEnemySpawnTimer = 0.4f; 
		score = 0; 
		enemyTypes = new List<float>();
		for (float i = 0; i < 5; i++)
		{
			///populate a list of enemy types
			/// this will be a more real thing later 
			enemyTypes.Add (i + 1f);
		}

		//c = GameObject.Find("Main Camera").GetComponent<GUIText>();	
		c.text = score.ToString(); 

		//GUIText = "Text";

	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(c.text);
		if (basicEnemySpawnCount <= 50)
		{
			if ((basicEnemySpawnTimer -= Time.deltaTime) <= 0)
			{
				randomXSpawnPos = UnityEngine.Random.Range(-3, 3);
				randomYSpawnPos = 18.0f;
				spawnNewEnemy();
				basicEnemySpawnTimer = basicEnemySpawnWaitTime;
				basicEnemySpawnCount++; 
			}
		}



	}
	void OnCollisionEnter(Collision collider)
	{

	}

	public void addToScore(int destroyedEnemy)
	{

		Debug.Log("Called");
		///score adds 100 * enemy multiplier
		score += enemyTypes[destroyedEnemy] * 100f; 
		c.text = score.ToString(); 

		//scoreController _scoreController = GetComponent<GUIText>(scoreController);
		//_scoreController.displayScore(score); 
	}
	
	private float newRandomFloat()
	{
		return (UnityEngine.Random.Range (-8, 8));
	}
	
	public void spawnNewEnemy()
	{		
		enemyStartPosition = new Vector3(randomXSpawnPos, randomYSpawnPos, -2);
		Instantiate (p_basicEnemy, enemyStartPosition, Quaternion.identity);
	}
	
}