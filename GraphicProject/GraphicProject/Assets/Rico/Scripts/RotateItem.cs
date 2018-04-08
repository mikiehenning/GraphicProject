using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateItem : MonoBehaviour {
//Setting space Rotations
	public float RotSpeed;
	public float flightSpeed;
//Setting public GameObjects
	public GameObject CockPit;
//Reference to the Player for movement
	public GameObject Player;
	PlayerController PlayerController;
	bool playerFound;

	void Start()
	{
		PlayerController = Player.GetComponent<PlayerController> ();
	}
//If Player is found, they lookAt the player and move "forward"
	void Update () 
	{
		if (!playerFound)
		transform.Rotate (new Vector3 (1, 0, 1) * RotSpeed);
		
		if (playerFound)
		{
			transform.LookAt (CockPit.transform.position);
			transform.Translate (transform.forward * (flightSpeed+PlayerController.Speed) * Time.deltaTime);
		}
	}



//If they are close enough and touching the "Sphere" object.
	void OnTriggerStay(Collider other)
	{
		if (other.gameObject.name == "Sphere") 
		{
			playerFound = true;
		}
	}
}
