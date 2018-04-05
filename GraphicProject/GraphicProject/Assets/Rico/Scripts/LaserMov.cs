using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMov : MonoBehaviour {

	public float laserSpeed;
	GameObject Aim;
	Transform Front;
	void Start ()
	{
		Aim = GameObject.Find ("Spawn_R");
	}
	

	void Update () 
	{

		transform.parent = null; 
		transform.Translate (new Vector3(0,0,1)* laserSpeed * Time.deltaTime);
		Destroy (gameObject, 2);
	}
}
