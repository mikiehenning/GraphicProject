using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour 
{

//Player Reference
	PlayerController Player;
	void Start ()
	{
		Player = GameObject.Find ("PixelMakeVoyager_WithGuns").GetComponent<PlayerController> ();
	}

//Checking Collisions and incrementing Health
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag==("Hazard"))
		{
			Player.Takedamage (40); 
			Destroy (other.gameObject);
		}
		if (other.gameObject.tag==("SuperHazard"))
		{
			Player.Takedamage (100);
			Destroy (other.gameObject);
		}
	}
}
