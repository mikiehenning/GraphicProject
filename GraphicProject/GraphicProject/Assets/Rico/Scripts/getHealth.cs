using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHealth : MonoBehaviour {
//Reference to player for Sounds and incrementation
	public GameObject Player;
	PlayerController PlayerController;

	void Start () 
	{
		PlayerController = Player.GetComponent<PlayerController> ();	
	}
	void OnTriggerEnter(Collider other)
	{
//When "02_CockpitExtension" is touched, send stuff to PlayerController
		if (other.gameObject.name == "02_CockpitExtension")
		{
			PlayerController.IncrementHealth ();
			PlayerController.Score += 100;
			Destroy (gameObject);

		}

	}
}
