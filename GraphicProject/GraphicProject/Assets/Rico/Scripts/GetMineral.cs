using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMineral : MonoBehaviour {

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
			Movement.minerals++;
			Movement.Score += 300;
			Destroy (gameObject);
		}

	}
}
