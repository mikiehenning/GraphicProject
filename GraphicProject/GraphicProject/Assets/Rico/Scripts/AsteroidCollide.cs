using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollide : MonoBehaviour {

	ShipMov movement;
	// Use this for initialization
	void Start ()
	{
		movement = GameObject.Find ("PixelMakeVoyager_WithGuns").GetComponent<ShipMov> ();
	}
	
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag==("Hazard"))
		{
			movement.Health -= 40;
			Destroy (other.gameObject);
		}
		if (other.gameObject.tag==("SuperHazard"))
		{
			movement.Health -= 100;
			Destroy (other.gameObject);
		}
	}
}
