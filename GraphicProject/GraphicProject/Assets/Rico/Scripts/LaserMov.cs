using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMov : MonoBehaviour {

	public float laserSpeed;
	Transform Front;
	ShipMov Movement;
	void Start ()
	{
		Movement = GameObject.Find ("PixelMakeVoyager_WithGuns").GetComponent<ShipMov> ();
	}
	

	void Update () 
	{

		transform.parent = null; 
		transform.Translate (new Vector3(0,0,1)* (laserSpeed+ Movement.Speed) * Time.deltaTime);
		Destroy (gameObject, 2);

	}
}
