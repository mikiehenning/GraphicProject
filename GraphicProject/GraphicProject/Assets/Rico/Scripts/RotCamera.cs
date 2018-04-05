using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotCamera : MonoBehaviour 
{

		float speed = 4;
		//I need these from HTML buttons
		bool tiltLock = false;
		bool rotateLock = false;
		bool zoomLock = false;



		
		void Update()
		{
			if (Input.GetMouseButton (0)) 
			{
				float x = Input.GetAxis ("Mouse X") * speed * Mathf.Deg2Rad;
				if (!rotateLock)
				{
					gameObject.transform.RotateAround (Vector3.up, x);
				}

			}
			
		}
		public void isTiltLocked()
		{
			tiltLock= !tiltLock;
		}
		public void isRotateLocked()
		{
			rotateLock= !rotateLock;
		}
		public void isZoomLocked()
		{
			zoomLock = !zoomLock;
		}
}
	
