using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSelection : MonoBehaviour 
{
	private GameObject[] GameList;
	private int index;
	private void Start()
	{
		GameList = new GameObject[transform.childCount];

		//Fill the array with our models
		for(int i=0; i<transform.childCount;i++)
			GameList [i] = transform.GetChild (i).gameObject;
		//We togge off their renderer
		foreach (GameObject go in GameList)
			go.SetActive (false);
		//We toggle on the first index
		if (GameList [0])
			GameList [0].SetActive (true);
	}

	public void ToggleLeft()
	{
		// Toggle off the current model
		GameList[index].SetActive(false);
		index--;
		if (index < 0)
			index = GameList.Length - 1;
		
		// Toggle on the current model
		GameList[index].SetActive(true);
	}

	public void ToggleRight()
	{
		// Toggle off the current model
		GameList[index].SetActive(false);
		index++;
		if (index == GameList.Length)
			index = 0;

		// Toggle on the current model
		GameList[index].SetActive(true);
	}
}
