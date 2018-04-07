using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSpace2 : MonoBehaviour 
{   
	public GameObject Health;
	public GameObject Fuel;
	public GameObject Minerals;
	public GameObject Asteroid;
	float AsteroidHealth = 100;
	ShipMov movement;

	void Start()
	{
		movement = GameObject.Find ("PixelMakeVoyager_WithGuns").GetComponent<ShipMov> ();
		gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(0,1000),Random.Range(0,1000),Random.Range(0,1000)));

	}

	void Update ()
	{
		transform.Rotate(new Vector3(Random.Range(0.1f,6),Random.Range(0.1f,6),Random.Range(0.1f,6))* Time.deltaTime);
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Laser(Clone)") 
		{
			Destroy (other.gameObject);
			AsteroidHealth -= 10;
			movement.Score += 1;
			if (AsteroidHealth == 0) 
			{
				SpawnItem ();
				Destroy (gameObject);
				movement.Score += 600;
			}
		}
	}


	void SpawnItem()
	{
		int x = Random.Range (1, 100);
		if (x <= 30) 
		{
			Instantiate (Health, this.transform.position, Quaternion.identity, null);
		} 
		else if (x >= 70)
		{
			Instantiate (Fuel, this.transform.position, Quaternion.identity, null);
		} 
		else if (x > 30 && x < 50)
		{
			Instantiate (Minerals, this.transform.position, Quaternion.identity, null);
		}
		if (x % 5 == 0) 
		{
			for (int i = 0; i < 4; i++)
			{
				GameObject Boom = Instantiate (Asteroid, this.transform.position, Quaternion.identity, null);
				Boom.GetComponent<Rigidbody> ().AddForce (Random.Range (0, 10000), Random.Range (0, 10000), Random.Range (0, 10000));
			}
		}
	}

}
