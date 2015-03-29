using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public Texture2D background;
	public int players = 0;

	void OnGUI () 
	{
		GUI.Label(new Rect(0, 0, Screen.width, Screen.height), background);

		GUI.Box(new Rect(50,50,1050,400), "Main Menu");


		if(GUI.Button(new Rect(400,100,80,20), "1 Player")) 
		{
			players = 1;        
		}
		else if(GUI.Button(new Rect(500,100,80,20), "2 Players")) 
		{
			players = 2;        
		}
		else if(GUI.Button(new Rect(600,100,80,20), "3 Players")) 
		{
			players = 3;
		}
		else if(GUI.Button(new Rect(700,100,80,20), "4 Players")) 
		{
			players = 4;        
		}

		if(GUI.Button(new Rect(540,200,80,20), "Play!") && players != 0) 
		{
			Application.LoadLevel("Test");
		}





	}
}
