using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMov : MonoBehaviour {

	public float laserSpeed;
//Reference to player so we can increase the speed of lasers if need be.
	PlayerController Player;
	void Start ()
	{
		Player = GameObject.Find ("PixelMakeVoyager_WithGuns").GetComponent<PlayerController> ();
	}
	

	void Update () 
	{

		transform.parent = null; 
		transform.Translate (new Vector3(0,0,1)* (laserSpeed+ Player.Speed) * Time.deltaTime);
		Destroy (gameObject, 2);

	}
}
