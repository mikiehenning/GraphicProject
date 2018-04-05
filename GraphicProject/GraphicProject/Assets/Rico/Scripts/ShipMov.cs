using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMov : MonoBehaviour 
{

	public float Speed;
	public Transform FlightCube;
	public Transform FlightCubeTop;
	public Transform FlightCubeBottom;
	public float tilt;
	public float Rot;
	Rigidbody rb;
	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		if (Input.GetKey (KeyCode.Space))
		{
			rb.AddForce (transform.forward * Speed);
			if (rb.velocity.magnitude > 300f) 
			{
				
			}
		}
		if(rb.velocity.magnitude > 0)
		{
//LEFT TURN
			if (Input.GetKey (KeyCode.A))
			{
				transform.RotateAround (FlightCube.position, new Vector3 (0, 1, 0) * Time.deltaTime / 3, -Rot);
		
			}
//RIGHT TURN
			if (Input.GetKey (KeyCode.D)) 
			{
				transform.RotateAround (FlightCube.position, new Vector3 (0, 1, 0) * Time.deltaTime / 3, Rot);

			}
//SkyBound
			if (Input.GetKey (KeyCode.S)) 
			{
				transform.RotateAround (FlightCubeTop.position, new Vector3 (0, 0, -1) * Time.deltaTime / 3, Rot);
			}
		}
//EarthBound
		if (Input.GetKey (KeyCode.W)) 
		{
			transform.RotateAround (FlightCubeBottom.position, new Vector3 (0, 0, 1) * Time.deltaTime / 3, Rot);
		}
	}
}
