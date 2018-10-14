using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winbutton : MonoBehaviour {
	public Button BigButton;
	public float time;
	// Use this for initialization
	void Start () {
		BigButton = GetComponent<Button>();
		BigButton.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		print("button");
		if(time < 0.01f)
		{
			if(bluescoremanager.BlueScore > redscoremanager.RedScore || bluescoremanager.BlueScore >= 7)
			{
				BigButton.gameObject.SetActive(true);
			}
			if(bluescoremanager.BlueScore < redscoremanager.RedScore || redscoremanager.RedScore >= 7)
			{
				BigButton.gameObject.SetActive(true);
			}
			if(bluescoremanager.BlueScore == redscoremanager.RedScore)
			{
				BigButton.gameObject.SetActive(true);
			}
		}
		
	}
}
