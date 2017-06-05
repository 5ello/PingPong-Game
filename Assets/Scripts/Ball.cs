using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	// Use this for initialization
	public float sx;
	public float sy;
    public Rigidbody rb;
    private Vector3 xyz = new Vector3(0, 0, 1.4f);
    
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Goal")
		{			
			Destroy(gameObject);
			sx = Random.Range(0, 2) == 0 ? -1 : 1;
      		sy = Random.Range(0, 2) == 0 ? -1 : 1;
			

            Rigidbody clone;
            clone = Instantiate(rb, xyz, transform.rotation) as Rigidbody;
            clone.velocity = new Vector3(10 * sx, 10 * sy, rb.transform.position.z);

		}
	}

    void Start() 
    {
        sx = Random.Range(0, 2) == 0 ? -1 : 1;
        sy = Random.Range(0, 2) == 0 ? -1 : 1;

		Rigidbody clone;
        clone = Instantiate(rb, xyz, transform.rotation) as Rigidbody;
        clone.velocity = new Vector3(10 * sx, 10 * sy, rb.transform.position.z);
    }

    void Update() 
    {
        
    }
}
