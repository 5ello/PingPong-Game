using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour {

	// Use this for initialization

	GameObject P1;
	GoalGreen Player1;

	GameObject P2;
	GoalRed Player2;

	GUIStyle style = new GUIStyle();
	void Start () {
		style.fontSize = 200;
		style.normal.textColor = Color.white;
	}
	
	// Update is called once per frame
	void Update () {
		P1 = GameObject.Find("GoalGreen");
	   	Player1 = P1.GetComponent<GoalGreen>();

		P2 = GameObject.Find("GoalRed");
	   	Player2 = P2.GetComponent<GoalRed>();
	}

	void OnGUI()
	{
		if(Player1.P2 >= 5){
			GUI.Label(new Rect(200, 100, 200, 200), "Player 2 Wins!!!", style);
			Time.timeScale = 0;
		}

		else if(Player2.P1 >= 5){
			GUI.Label(new Rect(200, 100, 200, 200), "Player 1 Wins!!!", style);
			Time.timeScale = 0;
		}
		else
			GUI.Label(new Rect((Screen.width - 500)/2, 100, 200, 200), Player2.P1 + " - " + Player1.P2, style);
	}
}
