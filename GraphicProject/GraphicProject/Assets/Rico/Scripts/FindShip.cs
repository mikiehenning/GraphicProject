using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindShip : MonoBehaviour 
{

	GameObject character;

	void Start () 
	{
		character = GameObject.Find ("PixelMakeVoyager_WithGuns");
	}
	
	// Update is called once per frame
	void Update () 
	{
			//transform.LookAt (character.transform);
	}
}
