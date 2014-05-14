using UnityEngine;
using System.Collections;

public class brickScript : MonoBehaviour {
	static int numBricks = 0;
	public int pointValue = 100;
	public int hitPoints =1;

	// Use this for initialization
	void Start () {
		numBricks++;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col)
	{
		hitPoints--;
		
		
		Die();	
		
		
	}	

	void OnTriggerEnter(Collider other){
		
		//	Debug.Log ("Trigger");
		hitPoints = 0;
		Die();
		
	}


	public void Die()
	{
		if (hitPoints <=0) 
		{
					
			Destroy( gameObject );
			numBricks--;
			//Debug.Log("Bricks:" + numBricks);
			if (numBricks <= 0)
			{
					Application.LoadLevel(Application.loadedLevel + 1);
					
			}
			
		}
	}


}
