using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	public GameObject UIText;
	public GameObject UIText2;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Tab)) {
	//		UIText.gameObject.SetActive (true);
			UIText2.gameObject.SetActive (true);
		} else {
//			UIText.gameObject.SetActive (false);
			UIText2.gameObject.SetActive (false);
		}
	}
}
