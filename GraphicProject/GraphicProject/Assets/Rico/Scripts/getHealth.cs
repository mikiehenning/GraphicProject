using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getHealth : MonoBehaviour {

	ShipMov movement;
	// Use this for initialization
	void Start () 
	{
		movement = GameObject.Find ("PixelMakeVoyager_WithGuns").GetComponent<ShipMov> ();	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "02_CockpitExtension")
		{
			movement.Health += 50;
			Destroy (gameObject);
			movement.Score += 100;
		}

	}
}
