using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStart : MonoBehaviour {


	public bool startGame;
	
	public GameObject gameHUD;
	public GameObject gameStartMenu;

	void Start ()
	{
		
	}
	
	void Awake () 
	{
		
	}
	
	void Update () 
	{
		if (startGame == true)
		{
			gameStartMenu.SetActive(false);
			gameHUD.SetActive(true);
		}
	}
	
	public void StartGame()
	{
		startGame = true;
	}
	
	public void QuitGame()
	{
		Application.Quit();
	}
	
}
