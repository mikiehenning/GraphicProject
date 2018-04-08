using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour 
{

//Player Reference
	public GameObject Player;
	PlayerController PlayerController;
	void Start ()
	{
		PlayerController = Player.GetComponent<PlayerController> ();
	}

//Checking Collisions and incrementing Health
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag==("Hazard"))
		{
			PlayerController.Takedamage (40); 
			Destroy (other.gameObject);
		}
		if (other.gameObject.tag==("SuperHazard"))
		{
			PlayerController.Takedamage (100);
			Destroy (other.gameObject);
		}
	}
}
