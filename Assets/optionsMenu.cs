using UnityEngine;
using System.Collections;

public class optionsMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {	
	
	}
	void OnGUI()
	{
		
		
		///music volume
		
		///SFX volume
		
		///credits
		
		///contact
		
		///back to menu
		
		GUIStyle upperRight = GUI.skin.GetStyle("Label");
		GUIStyle upperLeft = GUI.skin.GetStyle("Label");
		
		if(GUI.Button(new Rect(((Screen.width / 2) - 150), 200, 300, 50), "Music"))
		{
			
		}
		
		if(GUI.Button(new Rect(((Screen.width / 2) - 150), Screen.height - 150, 300, 50), "SFX"))
		{
			
		}
		
		if(GUI.Button(new Rect(((Screen.width / 2) - 150), Screen.height - 50, 300, 50), "Credits"))
		{
			
		}
		
		if(GUI.Button(new Rect(((Screen.width / 2) - 150), Screen.height - 50, 300, 50), "Contact"))
		{
					
		}
		
		if(GUI.Button(new Rect(((Screen.width / 2) - 150), Screen.height - 50, 300, 50), "Back"))
		{
			
		}
		
		upperRight.alignment = TextAnchor.UpperRight;
		
		/*GUI.DrawTexture (new Rect (0, Screen.height - buttonHeight, buttonWidth, buttonHeight),leftTexture);
		GUI.DrawTexture (new Rect (Screen.width - (buttonWidth), Screen.height - buttonHeight, buttonWidth, buttonHeight),rightTexture);
		
		GUI.Label(new Rect((Screen.width - 150), 0, 150, 20),"Score = " + (score * 100).ToString(), justifiedRight);
		GUI.Label(new Rect((Screen.width - 150), 30, 150, 20), multiplier.ToString() +"x multiplier", justifiedRight);*/
	}
}
