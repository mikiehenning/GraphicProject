using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

	public GameObject Shot;
	GameObject bullet;
	Transform R_Gun;
	Transform L_Gun;
	bool LR;
	float period=0;
	float Delay=0.2f;
	void Start()
	{
		R_Gun = GameObject.Find ("Spawn_R").transform;
		L_Gun = GameObject.Find ("Spawn_L").transform;
	}
	void Update () 
	{
		//.5 second Delay
		period += Time.deltaTime;

		if (period > Delay)
		{
			if (Input.GetKey (KeyCode.Alpha1))
			{
				LR = !LR;
				Instantiate (Shot, Switch ().position,Switch().rotation,Switch());
				period = 0;
			}
		}
	}
	private Transform Switch()
	{ 
		return LR? R_Gun:L_Gun;  
	}
}
