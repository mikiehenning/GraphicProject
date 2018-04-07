using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSpace : MonoBehaviour 
{

	public GameObject Health;
	public GameObject Fuel;
	public GameObject Minerals;
	float AsteroidHealth = 30;
	ShipMov movement;
	void Start()
	{
		movement = GameObject.Find ("PixelMakeVoyager_WithGuns").GetComponent<ShipMov> ();
		gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(0,100),Random.Range(0,100),Random.Range(0,100)));
	}

	void Update ()
	{
		transform.Rotate(new Vector3(Random.Range(0.1f,1),Random.Range(0.1f,1),Random.Range(0.1f,1) * Time.deltaTime));

	}		
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "Laser(Clone)") 
		{
			AsteroidHealth -= 10;
			movement.Score += 1;
			Destroy (other.gameObject);
			if (AsteroidHealth == 0) 
			{
				SpawnItem ();
				Destroy (gameObject);
				movement.Score += 50;
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
		else if (x>=70)
		{
			Instantiate (Fuel, this.transform.position, Quaternion.identity, null);
		}
		else if (x > 30 && x < 50)
		{
			Instantiate (Minerals, this.transform.position, Quaternion.identity, null);
		}
	}
}
