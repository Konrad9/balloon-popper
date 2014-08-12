using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	void OnGUI()
	{
		///Start, goes to game
		///Options, goes to options menu
		///Exit, closes app (on PC), needed on W8 tablet or phone? definitely not needed on iOS or Android
		
				
								
	
	
		GUIStyle upperRight = GUI.skin.GetStyle("Label");
		GUIStyle upperLeft = GUI.skin.GetStyle("Label");
		
		if(GUI.Button(new Rect(((Screen.width / 2) - 150), 200, 300, 50), "Start"))
		{
			Application.LoadLevel("Level1");
		}
		
		if(GUI.Button(new Rect(((Screen.width / 2) - 150), Screen.height - 150, 300, 50), "Options"))
		{
			
		}
		
		if(GUI.Button(new Rect(((Screen.width / 2) - 150), Screen.height - 50, 300, 50), "Exit"))
		{
			
		}
		
		upperRight.alignment = TextAnchor.UpperRight;
		
		/*GUI.DrawTexture (new Rect (0, Screen.height - buttonHeight, buttonWidth, buttonHeight),leftTexture);
		GUI.DrawTexture (new Rect (Screen.width - (buttonWidth), Screen.height - buttonHeight, buttonWidth, buttonHeight),rightTexture);
		
		GUI.Label(new Rect((Screen.width - 150), 0, 150, 20),"Score = " + (score * 100).ToString(), justifiedRight);
		GUI.Label(new Rect((Screen.width - 150), 30, 150, 20), multiplier.ToString() +"x multiplier", justifiedRight);*/
	}
	
	
	
}
