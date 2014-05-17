using UnityEngine;
using System.Collections;

public class paddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
		GameObject ball = GameObject.Find("Ball");
		ball.rigidbody.AddForce(0, 600, 0);
	}
	
	// Update is called once per frame
	void Update () {

		//Mouse Input
		transform.Translate(Input.GetAxis("Mouse X"), 0, 0);

		//Keyboard and Gamepad Input
		transform.Translate(100 * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);

		//Clamp Movement
		transform.position = new 
				Vector3(
							Mathf.Clamp(transform.position.x, -8.0f, 8.0f), 
							transform.position.y, 
							transform.position.z
				);

	}


	void OnCollisionEnter(Collision col) {
		foreach (ContactPoint contact in col.contacts){
			if (contact.thisCollider == collider){
				float english = contact.point.x - transform.position.x;
				contact.otherCollider.rigidbody.AddForce( 200f * english, 10f, 0);
			}
		}
		
	}
}
