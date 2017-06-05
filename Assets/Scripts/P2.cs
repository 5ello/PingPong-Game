using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow) && gameObject.transform.position.y < 3.5){

				transform.Translate(Vector3.up * Time.deltaTime * 20);
		}
		else if(Input.GetKey(KeyCode.DownArrow) && gameObject.transform.position.y > -3.5){

				transform.Translate(Vector3.down * Time.deltaTime * 20);
		}
	}
}