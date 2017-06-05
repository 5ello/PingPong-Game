using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalGreen : MonoBehaviour {

	public int P2 = 0;
	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Ball"){

			if(gameObject.name == "GoalGreen"){
				P2++;
			}
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
