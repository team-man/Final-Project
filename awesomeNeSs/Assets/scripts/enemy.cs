using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
	public float runspeed = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

			transform.Translate (new Vector3 (0f , 0f, runspeed*Time.deltaTime));

	}
}


//https://www.youtube.com/watch?v=2kV-6pZJwrs