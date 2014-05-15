using UnityEngine;
using System.Collections;

public class brickScript : MonoBehaviour {
	static int numBricks = 0;
	public int pointValue = 100;
	public int hitPoints =1;
	public GameObject powerup;
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
		
		hitPoints = 0;
		Die();
		
	}


	public void Die()
	{
		if (hitPoints <=0) 
		{Debug.Log(Random.Range(0,2));
			//Power up Lotto
			if (Random.Range(0,2) == 1){

				GameObject pup = (GameObject)Instantiate(powerup, gameObject.transform.position, Quaternion.Euler(0, 0, 90));
				pup.rigidbody.AddForce(Random.Range(-1f, 1f), 7, 0, ForceMode.Impulse);
				GameObject.Find ("DeathField").GetComponent<DeathScript>().lives++;
				Destroy(pup, 3);

			}


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
