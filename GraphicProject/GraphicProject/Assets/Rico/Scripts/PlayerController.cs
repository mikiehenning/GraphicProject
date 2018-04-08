using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController: MonoBehaviour 
{
//UI Elements
	public Slider HealthBar;
	public Slider FuelBar;
	public Text ScoreText;
	public Text HealthText;
	public Text FuelText;


//Things to keep track of for other scripts
	public float Fuel;
	public float Health;
	public float Score;
	public float Mineral;

//Sound Based Elements for Objects
	public AudioClip RockHitFX;
	public AudioClip HealthFX;
	public AudioClip FuelFX;
	public AudioClip MineralFX;
	public AudioClip BoosterFX;
	public AudioClip StopBoosterFX;
	AudioSource SoundMaker;

//Other things 
	public float WarpSpeed;
	public float Speed;
	public float TurnSpeed;
	public float Rot;
	public float lossRate;
	public GameObject Warp;
	bool thrust = false;

	void Start()
	{
		Mineral = 0;
		Score = 0;
		Fuel = 100;
		Health = 250;
		thrust = false;
		SoundMaker = gameObject.GetComponent<AudioSource> ();
		Warp.SetActive (false);

	}
		
//Using Update to adjust UI elements
	void Update()
	{
		ScoreText.text = "Score:" + Score.ToString() ;
		HealthText.text = Health.ToString () + "/250";
		FuelText.text = Mathf.Round(Fuel).ToString () + "/100";
		HealthBar.value = Mathf.Round (Health);
		FuelBar.value = Mathf.Round (Fuel);
	}



//Setting up Game Conditions and movement
	void FixedUpdate () 
	{
		if (Fuel > 100) Fuel = 100;

		if (Health > 250) Health = 250;

		if (Fuel < 0) Fuel = 0;

		Fuel = Fuel - Time.deltaTime * lossRate;
		if (Fuel > 0)
		{
			transform.Translate (new Vector3 (0, 0, 1) * Speed * Time.deltaTime);
//LEFT TURN
			if (Input.GetKey (KeyCode.A)) 
				transform.Rotate (new Vector3 (0, -1, 0) * Time.deltaTime * TurnSpeed);	
//RIGHT TURN
			if (Input.GetKey (KeyCode.D))
				transform.Rotate (new Vector3 (0, 1, 0) * Time.deltaTime * TurnSpeed);
//SkyBound
			if (Input.GetKey (KeyCode.S))
				transform.Rotate (new Vector3 (-1, 0, 0) * Time.deltaTime * TurnSpeed);
//EarthBound
			if (Input.GetKey (KeyCode.W)) 
				transform.Rotate (new Vector3 (1, 0, 0) * Time.deltaTime * TurnSpeed);
//Speed Boost that also increases rate of fuel loss
			if (Input.GetKeyDown (KeyCode.Space)) 
			{
				thrust = !thrust;
				if (thrust) 
				{
					SoundMaker.PlayOneShot (BoosterFX,2f);
					Speed = Speed * WarpSpeed;
					lossRate = lossRate * 2;
				}
				if (!thrust) 
				{
					SoundMaker.PlayOneShot (StopBoosterFX, .2f);
					Speed /= WarpSpeed;
					lossRate /= 2;
				}
				Warp.SetActive (!Warp.activeSelf);
			}
		}
	}


//Sound Effects and incrementations from other gameObjects
	public void IncrementHealth()
	{
		Health+=50;
		SoundMaker.PlayOneShot (HealthFX,1f);

	}
	public void IncrementFuel()
	{
		Fuel += 100;
		SoundMaker.PlayOneShot (FuelFX,1f);
	}
	public void IncrementMineral()
	{
		Mineral++;
		SoundMaker.PlayOneShot (MineralFX,1f);
	}
	public void Takedamage(int damage)
	{
		Health -= damage;
		SoundMaker.PlayOneShot (RockHitFX,1f);
	}

}
