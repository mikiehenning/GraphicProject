using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelGet : MonoBehaviour {

	ShipMov Movement;
	GameObject Ship;
	void Start()
	{
		Ship = GameObject.Find ("PixelMakeVoyager_WithGuns");
		Movement = Ship.GetComponent<ShipMov> ();
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "02_CockpitExtension")
		{
			Movement.Fuel += 120;
			Movement.Score += 100;
			Destroy (gameObject);
		}

	}
}
