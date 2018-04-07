using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMov : MonoBehaviour 
{


	//Things to keep track of for other scripts
	public float Fuel;
	public float Health;
	public float Score;
	public float minerals;
	//Other things 
	GameObject Warp;
	public float Speed;
	public float TurnSpeed;
	public float Rot;
	public float lossRate;
	bool thrust = false;
	Rigidbody rb;
	void Start()
	{
		minerals = 0;
		Score = 0;
		Fuel = 100;
		Health = 250;
		Warp = GameObject.Find ("Warp_Drive_A");
		Warp.SetActive (false);
		Warp.SetActive (false);
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Fuel > 100) 
		{
			Fuel = 100;
		}
		if (Health > 250) 
		{
			Health = 250;
		}
		if (Fuel < 0) 
		{
			Fuel = 0;
		}
		if (Health < 1)
		{
			Destroy (gameObject);
		}

		
		Fuel = Fuel - Time.deltaTime * lossRate;
		if (Fuel > 0)
		{
			transform.Translate (new Vector3 (0, 0, 1) * Speed * Time.deltaTime);
//LEFT TURN
			if (Input.GetKey (KeyCode.A)) 
			{
				transform.Rotate (new Vector3 (0, -1, 0) * Time.deltaTime * TurnSpeed);
			}
//RIGHT TURN
			if (Input.GetKey (KeyCode.D)) 
			{
			
				transform.Rotate (new Vector3 (0, 1, 0) * Time.deltaTime * TurnSpeed);

			}
//SkyBound
			if (Input.GetKey (KeyCode.S)) 
			{
				transform.Rotate (new Vector3 (-1, 0, 0) * Time.deltaTime * TurnSpeed);
			}
//EarthBound
			if (Input.GetKey (KeyCode.W)) 
			{
				transform.Rotate (new Vector3 (1, 0, 0) * Time.deltaTime * TurnSpeed);
			}
			if (Input.GetKeyDown (KeyCode.Space)) 
			{
				
				thrust = !thrust;
				Warp.SetActive (thrust);
				if (thrust) 
				{
					Speed = Speed * 8;
					lossRate = lossRate * 2;
				}
				if (!thrust) 
				{
			     	Speed /= 8;
					lossRate /= 2;
				}
			}
		}
	}
}
