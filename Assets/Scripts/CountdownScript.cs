using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CountdownScript : MonoBehaviour
{
	int countDownStartValue = 120;
	public Text timerUI;

    void Start()
	{
		countDownTimer();
	}

	void countDownTimer()
	{
		if (countDownStartValue > 0) 
		{
			TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
			timerUI.text=spanTime.Minutes + " : " + spanTime.Seconds;
			countDownStartValue--;
			Invoke ("countDownTimer", 1.0f);
		} 
		else 
		{
			Debug.Log ("GameOver!");
		}
	}
}
