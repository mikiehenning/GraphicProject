using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCam : MonoBehaviour {

	
	// Update is called once per frame
	void Update () 
	{
		transform.position = GameObject.Find ("PixelMakeVoyager_WithGuns").transform.position;	
	}
}
