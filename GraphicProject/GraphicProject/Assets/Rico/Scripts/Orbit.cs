using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

	public float OrbitSpeed;
	void Update () 
	{
		transform.RotateAround (GameObject.Find ("Sun").transform.position,new Vector3(0,1,0)*Time.deltaTime,.00365f);	
	}
}
