using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermodified : MonoBehaviour {
	CursorLockMode wantedMode;
	bool islocked=true;

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		islocked = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.Escape) && islocked == true) {
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			islocked = false;
		} 
			

		
	}
}
