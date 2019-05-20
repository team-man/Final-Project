using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupscript : MonoBehaviour {


	float throwForce = 3000;

	public bool canHold = true;
	public GameObject item;
	public GameObject tempParent;
	public Transform guide;
	public bool isHolding = false;
	float distance;

	// Use this for initialization
	void Start () {
		item.GetComponent<Rigidbody> ().useGravity = true;
	}

	// Update is called once per frame
	void Update () {

		distance = Vector3.Distance(item.transform.position, guide.transform.position);

		if (isHolding==true)
		{

			item.GetComponent<Rigidbody>().useGravity = false;
			item.GetComponent<Rigidbody>().detectCollisions = true;
			item.GetComponent<Rigidbody>().isKinematic = false;
			item.transform.parent = tempParent.transform;
			item.transform.position = guide.transform.position;
			if (Input.GetMouseButtonDown(1))
			{
				Debug.Log("Trying to throw");
				item.GetComponent<Rigidbody>().AddForce(guide.transform.forward * throwForce);
				isHolding = false;
			}
		}
		else
		{
			item.GetComponent<Rigidbody>().useGravity = true;
			item.GetComponent<Rigidbody>().isKinematic = false;
			item.transform.parent = null;
		}

//		if (Input.GetKey(KeyCode.LeftArrow))
//		{
//			transform.Rotate (-100f*Time.deltaTime, 0, 0);
//		}
//		if (Input.GetKey(KeyCode.UpArrow))
//		{
//			transform.Rotate (0,0, 100f*Time.deltaTime);
//		}
//		if (Input.GetKey(KeyCode.RightArrow))
//		{
//			transform.Rotate (100f*Time.deltaTime, 0, 0);
//		}
//		if (Input.GetKey(KeyCode.DownArrow))
//		{
//			transform.Rotate (0, 0, -100f*Time.deltaTime);
//		}

		
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			transform.Rotate (-90, 0, 0);
		}
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			transform.Rotate (0,0, 90);
		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			transform.Rotate (90, 0, 0);
		}
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			transform.Rotate (0, 0, -90);
		}
	}

	void OnMouseDown()

	{
		if (distance <= 1.5f)
		{
			isHolding = true;

		}
	}
	void OnMouseUp()
	{
		isHolding = false;
	}

	private void OnCollisionEnter(Collision collision)
	{
		isHolding = false;
	}


}﻿