using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMineral : MonoBehaviour 
{
//Reference to Player for Sounds and incrementation 
	PlayerController Player;

	void Start()
	{
		Player= GameObject.Find ("PixelMakeVoyager_WithGuns").GetComponent<PlayerController> ();

	}
	void OnTriggerEnter(Collider other)
	{
//When "02_CockpitExtension" is touched, send stuff to Player
		if (other.gameObject.name == "02_CockpitExtension")
		{
			Player.IncrementMineral ();
			Player.Score += 300;
			Destroy (gameObject);
		}

	}
}
