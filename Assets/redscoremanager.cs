using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class redscoremanager : MonoBehaviour {
	//public Camera CameraToFollow;
	//public float DistanceFromCamera;
	public static int RedScore;
	public Text RedText;

	// Use this for initialization
	void Start () {
		RedText = GetComponent<Text>();
		RedScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		RedText.text = "Red Score: " + RedScore;
		//transform.position = CameraToFollow.transform.position + CameraToFollow.transform.forward * DistanceFromCamera;
	}
}
