using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public Text timer;
	public float time;
	// Use this for initialization
	void Start () {
		timer = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if(time > 0 && time >= 10.0f)
		{
			time -= Time.deltaTime;
			timer.text = "Time: " + Mathf.RoundToInt(time);
		}
		if(time >= 0  && time < 10.0f)
		{
			time -= Time.deltaTime;
			timer.text = "Time: " + System.Math.Round(time, 2);
		}
		if(time <= 0)
		{
			timer.text = "Time: " + Mathf.RoundToInt(time);
		}
	}
}
