using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class movementController : MonoBehaviour {

	public GameObject bullet;
	public GameObject balloon;
	public GameObject player;
	

	private int score; 
	private int scoreIncrement; 
	private int multiplier; 
	private int incrementMultiplier;

	private float spawnHeight;

	private Vector2 firePosition;
	Vector2 offset;

	private float spawnTimer;
	private float masterSpawnTimer; 
	private bool spawnNewBalloon;
	private float activeTime;

	public Texture2D rightTexture;
	public Texture2D leftTexture; 

	private float buttonWidth;
	private float buttonHeight; 
	
	private float momentum; 
	
	bool decreaseMomentum;
	
	
	
	///can I save the positions of all of the exploded balloons? populate with little dots after the level ends
	///save locations of fallen balloons, show where they hit the ground. also useful for debugging to see if there's an area that's hard to get to
	///needs a menu
	///needs sound effects
	///needs some damn art 

	/// <summary>
	/// count and display how many baloons popped, how many in a row, score multiplier 
	/// </summary>

	// Use this for initialization
	void Start () {
		offset = new Vector2 (0f, 0.5f);
		firePosition = gameObject.transform.position; 
		firePosition += offset;
		buttonWidth = 60;
		buttonHeight = 60; 
		spawnHeight = 100.0f;
		spawnTimer = 3.0f;
		score = 0; 
		multiplier = 1; 
		scoreIncrement = 10;
		momentum = 0.0f;
		masterSpawnTimer = 1.7f;
		decreaseMomentum = false;
		incrementMultiplier = 0; 
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((spawnTimer -= Time.deltaTime) <= 0) 
		{
			spawnBalloon();
			spawnTimer = masterSpawnTimer;
		}
		
		if (Time.realtimeSinceStartup %6 == 0)
		{
			if (masterSpawnTimer > 0.5f)		
			{
				masterSpawnTimer -= .1f;			
			}
		}
		

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			decreaseMomentum = false;
			if (player.transform.position.x >= -8)
			{
				if (momentum <= 20.0f && momentum >= -20.0f)
				{
					momentum -= 1.0f;
				}	
			}
			else
			{
				momentum = 0; 	
			}
		}	
			
		if (Input.GetKey(KeyCode.RightArrow))
		{
			decreaseMomentum = false;
			if (player.transform.position.x <= 8)
			{
				if (momentum <= 20.0f && momentum >= -20.0f)
				{
					momentum += 1.0f;
				}
			}			
			else
			{
				momentum = 0; 	
			}
		}
		
		if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
		{
			decreaseMomentum = true;
		}
		
		
		if(decreaseMomentum == true)
		{
			momentum = decreaseVelocity(momentum);				
		}
		
		Debug.Log(momentum);
		player.rigidbody2D.velocity = new Vector2(momentum,0);
		
		if (Input.GetKeyDown(KeyCode.Space))
		{
			firePosition = player.transform.position; 
			firePosition += offset;
			fire();
		}
		

	}
	
	float decreaseVelocity(float l_momentum)
	{
		if (l_momentum < 0f)
		{
			return l_momentum + 1.0f;		
		}
		else if (momentum > 0f)
		{
			return l_momentum - 1.0f; 
		}
		
		return l_momentum; 
		
	}

	public void increaseScore(string tag)
	{
		Debug.Log("test");
		Debug.Log(tag);

		///call this every time collision happens on a balloon. if it collides with a bullet tag, increase score and multiplier, if it collides with floor tag, reset multiplier
		if (tag == "bullet") 
		{
			score += scoreIncrement * multiplier;
			if (incrementMultiplier++ >= 4)
			{
				multiplier += 1 ;
				incrementMultiplier = 0;
			}
		}
		else
		{
			multiplier = 1; 
		}

	}

	void fire()
	{
		Instantiate (bullet, firePosition, Quaternion.identity);
	}

	void spawnBalloon()
	{
		float xPosition;
		//Debug.Log (Screen.width);
		xPosition = UnityEngine.Random.Range (0, Screen.width);
		Vector2 spawnPosition = new Vector2 (xPosition, spawnHeight);
		spawnPosition = Camera.main.ScreenToWorldPoint (spawnPosition);
		spawnPosition = new Vector2 (spawnPosition.x, spawnPosition.y + 12);
		Instantiate (balloon, spawnPosition, Quaternion.identity);
	}

	void OnGUI()
	{
		GUIStyle justifiedRight = GUI.skin.GetStyle("Label");
		
		justifiedRight.alignment = TextAnchor.UpperRight;
		
		GUI.DrawTexture (new Rect (0, Screen.height - buttonHeight, buttonWidth, buttonHeight),leftTexture);
		GUI.DrawTexture (new Rect (Screen.width - (buttonWidth), Screen.height - buttonHeight, buttonWidth, buttonHeight),rightTexture);
		
		GUI.Label(new Rect((Screen.width - 150), 0, 150, 20),"Score = " + (score * 100).ToString(), justifiedRight);
		GUI.Label(new Rect((Screen.width - 150), 30, 150, 20), multiplier.ToString() +"x multiplier", justifiedRight);
	}



}























