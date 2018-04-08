using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
//Laser Prefab
	public GameObject Laser;

//Variables to manipulate
	public Transform R_Gun;
	public Transform L_Gun;
	bool LR;
	float period=0;
	float Delay=0.2f;


	void Update () 
	{
//.5 second Delay
		period += Time.deltaTime;

		if (period > Delay)
		{
			if (Input.GetMouseButton (0))
			{
//Rotation of Gun
				LR = !LR;
				Instantiate (Laser, Switch ().position,Switch().rotation,Switch());
				period = 0;
			}
		}
	}
//Rotation of Gun
	private Transform Switch()
	{ 
		return LR? R_Gun:L_Gun;  
	}
}
