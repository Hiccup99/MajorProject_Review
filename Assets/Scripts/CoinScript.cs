using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour {

    public int amount=10;
	Text text;
    private void Start()
    {
        text = GetComponent<Text>();    }
    public void OnIncrement()
    {
        amount++;
        text.text = amount.ToString();
    }
    public void OnDecrement()
    {
        if(amount>0)
        {
            amount--;
            text.text = amount.ToString();
        }
    }
    public void OnReset()
    {
        amount = 0;
        text.text = amount.ToString();
    }
}
