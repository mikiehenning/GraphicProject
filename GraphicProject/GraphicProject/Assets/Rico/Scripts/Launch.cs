using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour {

	bool isGrounded = true;
	public float LaunchSpeed;
	bool hasLaunched;

	void Start()
	{
		hasLaunched = false;
	}
	// Update is called once per frame
	void Update () 
	{
		if (isGrounded) 
		{
			if (Input.GetKey(KeyCode.L)) 
			{
				gameObject.transform.Translate (new Vector3 (0, 20, 0) * Time.deltaTime);
				hasLaunched = true;
			}
		}
	}
}
