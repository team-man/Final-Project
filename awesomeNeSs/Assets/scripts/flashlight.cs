using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour {
public GameObject lightObject;
	public Light myLightComponent;
	// Use this for initialization
	void Start () {
		lightObject = GameObject.Find ("Spotlight");
			myLightComponent = lightObject.GetComponent<Light>();
//		myLightComponent.enabled;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space)) {
			myLightComponent.enabled = !myLightComponent.enabled;
		} 
	}
}
