using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateItem : MonoBehaviour {

	public float RotSpeed;
	public float flightSpeed;
	PlayerController Player;
	bool playerFound;

	void Start()
	{
		Player = GameObject.Find ("PixelMakeVoyager_WithGuns").GetComponent<PlayerController> ();
	}
	void Update () 
	{
		if (!playerFound)
		transform.Rotate (new Vector3 (1, 0, 1) * RotSpeed);
		
		if (playerFound)
		{
			transform.LookAt (GameObject.Find ("01_Cockpit").transform.position);
			transform.Translate (transform.forward * (flightSpeed+Player.Speed) * Time.deltaTime);
		}
	}




	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.name == "Sphere") 
		{
			playerFound = true;
		}
	}
}
