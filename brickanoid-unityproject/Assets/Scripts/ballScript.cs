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


	void OnCollisionEnter(Collision col) {

		//Avoid boring bounces
		Debug.Log ("Y" + rigidbody.velocity.y + " : " + Time.time);
		if(rigidbody.velocity.y < 2  && Mathf.Sign(rigidbody.velocity.y) == 1 && col.transform.tag == "walls") {
			rigidbody.AddForce(0f, 200f, 0f);
			Debug.Log (Time.time + "  Bounce" + rigidbody.velocity.y);
		} 
		else if(rigidbody.velocity.y > -2 && Mathf.Sign(rigidbody.velocity.y) == -1 && col.transform.tag == "walls"){
			rigidbody.AddForce(0f, -200f, 0f);
			Debug.Log (Time.time + "  Bounce" + rigidbody.velocity.y);
		}




	}

}
