using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSpace2 : MonoBehaviour 
{   
//Behaviors for Asteroids

//Item Drops
	public GameObject Health;
	public GameObject Fuel;
	public GameObject Minerals;
//Upon Explosion
	public GameObject Asteroid;
//Other
	float AsteroidHealth = 100;

//Referencing the PlayerController
	public GameObject Player;
	PlayerController PlayerController;

//Make sure that the Script can talk to the PlayerController
	void Start()
	{
		
		PlayerController = Player.GetComponent<PlayerController> ();
		gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(0,1000),Random.Range(0,1000),Random.Range(0,1000)));

	}

//Space-like Rotation Vectors
	void Update ()
	{
		transform.Rotate(new Vector3(Random.Range(0.1f,6),Random.Range(0.1f,6),Random.Range(0.1f,6))* Time.deltaTime);
	}

	void OnCollisionEnter(Collision other)
	{
//When "Laser(Clone)" collides with object do these things
		if (other.gameObject.name == "Laser(Clone)") 
		{
			Destroy (other.gameObject);
			AsteroidHealth -= 10;
			PlayerController.Score += 1;

			if (AsteroidHealth == 0) 
			{
				
//PlayerController.Takedamage plays a sound we want, 0 is used because no damage is actually taken
				PlayerController.Takedamage (0);
				SpawnItem ();
				PlayerController.Score += 600;
				Destroy (gameObject);
			}
		}
	}

	//Randomly Spawns in an Object based on these figures
	void SpawnItem()
	{
//Random.Range  is (inclusive,Exclusive) so, 101 makes sense. 
	int x = Random.Range (1, 101);

//This is a 30% chance for Health Drop
	if (x <= 30) 
		Instantiate (Health, this.transform.position, Quaternion.identity, null);
		
//This is a 30% chance for a Fuel Drop

	else if (x>=70)
		Instantiate (Fuel, this.transform.position, Quaternion.identity, null);
		
//This is a 30% chance to drop Minerals (leaving a 10% chance that nothing is dropped)

	else if (x > 30 && x <= 60)
		Instantiate (Minerals, this.transform.position, Quaternion.identity, null);
	
//Giant Asteroids, upon exploding, create 4 new asteroids and they explode away
		for (int i = 0; i < 4; i++)
		{
			GameObject Boom = Instantiate (Asteroid, this.transform.position, Quaternion.identity, null);
			Boom.GetComponent<Rigidbody> ().AddForce (Random.Range (0, 10000), Random.Range (0, 10000), Random.Range (0, 10000));
		}
	}

}


