using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFuel : MonoBehaviour {
//Reference to Player for Sound
	PlayerController Player;

	void Start()
	{
		Player = GameObject.Find ("PixelMakeVoyager_WithGuns").GetComponent<PlayerController>();
	}

	void OnTriggerEnter(Collider other)
	{
//When "02_CockpitExtension" is touched send Player stuff
		if (other.gameObject.name == "02_CockpitExtension")
		{
			Player.IncrementFuel ();
			Player.Score += 100;
			Destroy (gameObject);
		}

	}
}
