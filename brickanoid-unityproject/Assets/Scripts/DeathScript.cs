using UnityEngine;
using System.Collections;

public class DeathScript : MonoBehaviour {
	public int lives = 3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter (Collision col)
	{
		lives--;
		col.rigidbody.velocity = Vector3.zero;
		col.transform.position = new Vector3(0,-6,0);
		col.rigidbody.AddForce(0, 600, 0);
			
		if (lives == 0){
			Application.LoadLevel("level01");
		}
	}	

}
