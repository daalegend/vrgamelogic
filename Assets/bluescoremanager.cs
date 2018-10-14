using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bluescoremanager : MonoBehaviour {
	//public Camera CameraToFollow;
	//public float DistanceFromCamera;
	public static int BlueScore;
	public Text BlueText;

	// Use this for initialization
	void Start () {
		BlueText = GetComponent<Text>();
		BlueScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		BlueText.text = "Blue Score: " + BlueScore;
		//transform.position = CameraToFollow.transform.position + CameraToFollow.transform.forward * DistanceFromCamera;
	}
}
