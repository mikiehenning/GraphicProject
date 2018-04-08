using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMineral : MonoBehaviour 
{
//Reference to PlayerController for Sounds and incrementation 
	public GameObject Player;
	PlayerController PlayerController;

	void Start()
	{
		PlayerController= Player.GetComponent<PlayerController> ();

	}
	void OnTriggerEnter(Collider other)
	{
//When "02_CockpitExtension" is touched, send stuff to PlayerController
		if (other.gameObject.name == "02_CockpitExtension")
		{
			PlayerController.IncrementMineral ();
			PlayerController.Score += 300;
			Destroy (gameObject);
		}

	}
}
