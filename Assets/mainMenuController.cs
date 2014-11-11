using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class mainMenuButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void newGame()
    {
        Application.LoadLevel(2);
    }

    public void test()
    {
        Debug.Log("test");
    }

    public void openSettingsMenu()
    {

    }

    public void exitGame()
    {

    }

    public void loadSaveGame()
    {

    }

    public void openLeaderBoard()
    {

    }
}

