using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMov : MonoBehaviour {

	public float laserSpeed;
//Reference to player so we can increase the speed of lasers if need be.
	public GameObject Player;
	PlayerController PlayerController;
	void Start ()
	{
		PlayerController = Player.GetComponent<PlayerController> ();
	}
	

	void Update () 
	{

		transform.parent = null; 
		transform.Translate (new Vector3(0,0,1)* (laserSpeed+ PlayerController.Speed) * Time.deltaTime);
		Destroy (gameObject, 2);

	}
}
