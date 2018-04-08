using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

	//Code used to move around Planets in the BackGround as well as Asteroids, they Circle around the Sun
	public float OrbitSpeed;
	void Update () 
	{
		transform.RotateAround (GameObject.Find ("Sun").transform.position,new Vector3(0,1,0)*Time.deltaTime*OrbitSpeed,.00365f);	
	}
}
