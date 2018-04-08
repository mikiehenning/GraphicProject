using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStuff : MonoBehaviour 
{
//LONG LIST OF OBJECTS TO INSTANTIATE
	public GameObject Asteroid_A;
	public GameObject Asteroid_B;
	public GameObject Asteroid_C;
	public GameObject Asteroid_D;
	public GameObject Asteroid_E;
	public GameObject Asteroid_F;
	public GameObject SuperA;
	public GameObject SuperB;
	public GameObject SuperC;
	public GameObject SuperD;
	public GameObject SuperE;
	public GameObject SuperF;

//Editor for stress testing
	public int numOfAsteroids;
	public int numOfSuper;

//Object placeholders
	GameObject Asteroid;
	GameObject SuperAsteroid;
//Reference to Player so that this script continues to spawn more objects
	PlayerController Player;


	void Start ()
	{
		SpawnAsteroids (numOfAsteroids);
		SpawnSuperAsteroids (numOfSuper);
		Player = GameObject.Find ("PixelMakeVoyager_WithGuns").GetComponent<PlayerController> ();
	}
	void Update()
	{
		if (Player.Score % 5000 == 0 && Player.Score !=0)
		{
			SpawnAsteroids (50);
			SpawnSuperAsteroids (20);
		}
	}
















//Randomly Spawns 1 of 7 types of asteroids "Amount" of times within a specific space
	void SpawnAsteroids(int Amount)
	{
		for (int i = 0; i < Amount; i++) 
		{
			float ASpawnX = Random.Range(0,1950);
			float ASpawny = Random.Range(0,1950);
			float ASpawnz = Random.Range(0,1950);
			int y = Random.Range (1, 7);
			switch (y)
			{
			case(1):
				{
					Asteroid = Asteroid_A;
					break;
				}
			case(2):
				{
					Asteroid = Asteroid_B;
					break;
				}
			case(3):
				{
					Asteroid = Asteroid_C;
					break;
				}
			case(4):
				{
					Asteroid = Asteroid_D;
					break;
				}
			case(5):
				{
					Asteroid = Asteroid_E;
					break;
				}
			case(6):
				{
					Asteroid = Asteroid_F;
					break;
				}
			}
			Instantiate (Asteroid,new Vector3(ASpawnX,ASpawny,ASpawnz), Quaternion.identity, null);
		}
	}


//Randomly Spawns 1 of 7 types of Super asteroids "Amount" of times within a specific space
	void SpawnSuperAsteroids(int Amount)
	{

		for(int i = 0; i < Amount; i++)
		{
			float SSpawnX = Random.Range(0,1950);
			float SSpawny = Random.Range(0,1950);
			float SSpawnz = Random.Range(0,1950);
			int y = Random.Range (1, 7);
			switch (y)
			{
			case(1):
				{
					SuperAsteroid = SuperA;
					break;
				}
			case(2):
				{
					SuperAsteroid = SuperB;
					break;
				}
			case(3):
				{
					SuperAsteroid = SuperC;
					break;
				}
			case(4):
				{
					SuperAsteroid = SuperD;
					break;
				}
			case(5):
				{
					SuperAsteroid = SuperE;
					break;
				}
			case(6):
				{
					SuperAsteroid = SuperF;
					break;
				}
			}
			Instantiate (SuperAsteroid,new Vector3(SSpawnX,SSpawny,SSpawnz), Quaternion.identity, null);
		}
	}
}


