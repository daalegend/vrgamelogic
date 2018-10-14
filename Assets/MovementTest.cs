using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour {
	public Vector3 start_pos;
	public float speed = 20f;
	public float time;
	// Use this for initializatio
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		Vector3 pos = transform.position;
		if(time > 0.01f)
		{
			if(Input.GetKey(KeyCode.W))
			{
				pos.z += speed * Time.deltaTime;
			}
			if(Input.GetKey(KeyCode.S))
			{
				pos.z -= speed * Time.deltaTime;
			}
			if(Input.GetKey(KeyCode.D))
			{
				pos.x += speed * Time.deltaTime;
			}
			if(Input.GetKey(KeyCode.A))
			{
				pos.x -= speed * Time.deltaTime;
			}
			transform.position = pos;
		}
	}
}
