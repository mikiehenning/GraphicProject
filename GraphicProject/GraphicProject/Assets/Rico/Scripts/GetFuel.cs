using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFuel : MonoBehaviour {
//Reference to Player for Sound
	public GameObject Player;
	PlayerController PlayerController;

	void Start()
	{
		PlayerController = Player.GetComponent<PlayerController>();
	}

	void OnTriggerEnter(Collider other)
	{
//When "02_CockpitExtension" is touched send Player stuff
		if (other.gameObject.name == "02_CockpitExtension")
		{
			PlayerController.IncrementFuel ();
			PlayerController.Score += 100;
			Destroy (gameObject);
		}

	}
}
