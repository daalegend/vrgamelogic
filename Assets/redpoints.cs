using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redpoints : MonoBehaviour {
	public Vector3 start_pos;
	public int scoreValue = 1;
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == "Capsule")
		{
			col.transform.position = start_pos;
			redscoremanager.RedScore += scoreValue;
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
