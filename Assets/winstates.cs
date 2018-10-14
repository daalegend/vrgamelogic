using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winstates : MonoBehaviour {
	public Text WinnerText;
	public float time;
	// Use this for initialization
	void Start () {
		WinnerText = GetComponent<Text>();
		WinnerText.GetComponent<Text>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if(time < 0.01f)
		{
			if(bluescoremanager.BlueScore > redscoremanager.RedScore || bluescoremanager.BlueScore >= 7)
			{
				WinnerText.GetComponent<Text>().enabled = true;
				WinnerText.text = "Blue Wins!";
			}
			if(bluescoremanager.BlueScore < redscoremanager.RedScore || redscoremanager.RedScore >= 7)
			{
				WinnerText.GetComponent<Text>().enabled = true;
				WinnerText.text = "Red Wins!";
			}
			if(bluescoremanager.BlueScore == redscoremanager.RedScore)
			{
				WinnerText.GetComponent<Text>().enabled = true;
				WinnerText.text = "It's a tie!";
			}
		}
		
	}
}
