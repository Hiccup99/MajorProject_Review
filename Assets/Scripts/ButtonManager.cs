using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour 
{
	private GameObject About;
	public void StartBtn(string Start)
	{
		SceneManager.LoadScene(Start);
	}
	public void ExitBtn()
	{
		Application.Quit();
		Debug.Log("Game is exiting");
	}
	public void PlayBtn(string Start)
	{
		SceneManager.LoadScene(Start);
	}
	public void Game_BackBtn(string Start)
	{
		SceneManager.LoadScene(Start);
	}
}
