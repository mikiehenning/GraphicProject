using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSpace : MonoBehaviour 
{
//Item Drops
	public GameObject Health;
	public GameObject Fuel;
	public GameObject Minerals;
//Setting AsteroidHealth
	float AsteroidHealth = 30;

//Reference to Player for Sounds and Incrementations
	PlayerController Player;
	void Start()
	{
		Player = GameObject.Find ("PixelMakeVoyager_WithGuns").GetComponent<PlayerController> ();
		gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(0,100),Random.Range(0,100),Random.Range(0,100)));
	}
//Constant Space-Rotation
	void Update ()
	{
		transform.Rotate(new Vector3(Random.Range(0.1f,1),Random.Range(0.1f,1),Random.Range(0.1f,1) * Time.deltaTime));

	}		
	void OnCollisionEnter(Collision other)
	{
//When "Laser(Clone)" collides with object do these things
		if (other.gameObject.name == "Laser(Clone)") 
		{
			AsteroidHealth -= 10;
			Player.Score += 1;
			Destroy (other.gameObject);
			if (AsteroidHealth == 0) 
			{
//Player.Takedamage plays a sound we want, 0 is used because no damage is actually taken
				Player.Takedamage (0);
				SpawnItem ();
				Destroy (gameObject);
				Player.Score += 50;
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

		//This is a 10% chance to drop Minerals (leaving a 30% chance that nothing is dropped)

		else if (x > 30 && x <= 40)
			Instantiate (Minerals, this.transform.position, Quaternion.identity, null);

	}
}
