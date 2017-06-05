using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalRed : MonoBehaviour {

	public int P1 = 0;
	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Ball"){

			if(gameObject.name == "GoalRed")
				P1++;
		}

	}

	// Update is called once per frame
	void Update () {
		
	}

}