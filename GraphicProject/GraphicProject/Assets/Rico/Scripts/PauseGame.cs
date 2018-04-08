using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PauseGame : MonoBehaviour {
//Setting up GameObjects that are used for a pause screen
	public GameObject pausePane;
	public GameObject LosePane1;
	public GameObject LosePane2;

//Setting a boolean for Restart
	bool canRestart = false;

//Reference to Player
	PlayerController Player;
	void Start()
	{
		LosePane1.SetActive (false);
		LosePane2.SetActive (false);
		Player = GameObject.Find ("PixelMakeVoyager_WithGuns").GetComponent<PlayerController> ();
		Time.timeScale = 0;
	}
	void Update()
	{
//Restart if Lost
		if (canRestart && Input.GetKeyDown (KeyCode.R)) 
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}

//Game Starts Paused
		if (Input.GetKeyDown(KeyCode.KeypadEnter))
		{
			if (!pausePane.activeSelf) 
			{
				Pause ();
			}
			else if (pausePane.activeSelf) 
			{
				Continuegame();
			}
		}

//GameOver Types
		if (Player.Fuel <= 0) 
		{
			
			GameOver1 ();
		}
		if (Player.Health <= 0) 
		{
			
			GameOver2 ();
		}
	}
//Actively Pausing the game
	private void Pause()
	{

		Time.timeScale = 0;
		pausePane.SetActive(true);
	}
//Actively Continuing the game
	private void Continuegame()
	{
		
		Time.timeScale = 1;
		pausePane.SetActive (false);
	}
//Lost from Fuel
	private void GameOver1()
	{
		

		Time.timeScale = 0;
		LosePane1.SetActive (true);
		canRestart = true;
	}
//Lost from Health
	private void GameOver2()
	{
		
		Time.timeScale = 0;
		LosePane2.SetActive (true);
		canRestart = true;
	}
}
