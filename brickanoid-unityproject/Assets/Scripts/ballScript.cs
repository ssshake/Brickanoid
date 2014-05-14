using UnityEngine;
using System.Collections;

public class ballScript : MonoBehaviour {
	public float maxSpeed = 20f; //Replace with your max speed
	public float minSpeed = 7f; //Replace with your max speed
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate()
	{
		
		
		if(rigidbody.velocity.magnitude > maxSpeed)
		{
			rigidbody.velocity = rigidbody.velocity.normalized * maxSpeed;
		}
		if(rigidbody.velocity.magnitude < minSpeed)
		{
			rigidbody.velocity = rigidbody.velocity.normalized * minSpeed;
		}
		
	}
}
