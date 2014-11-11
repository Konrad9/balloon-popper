using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

public class mainMenuController : MonoBehaviour {
    public Canvas primaryMenu;
    public Canvas settingsMenu;
    public Slider sfxSlider; 
	// Use this for initialization
	void Start () {
        
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void newGame()
    {
        Application.LoadLevel("balloonsInSpace");
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

    public void sfxVolume()
    {
        AudioListener.volume = sfxSlider.value; 
    }
    public void musicVolume()
    {
        
    }

    public void openLeaderBoard()
    {

    }
}

