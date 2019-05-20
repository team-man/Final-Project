using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRaycastSelect : Raycast {
	Color oldColor;
	public Color selectionColor;


	// Update is called once per frame
	protected override void OnRaycastEnter (GameObject target)
	{
		oldColor = target.GetComponent<Renderer> ().material.GetColor ("_Color");
		target.GetComponent<Renderer> ().material.SetColor ("_Color", selectionColor);

	}
	protected override void OnRaycastLeave (GameObject target)
	{
		target.GetComponent<Renderer> ().material.SetColor ("_Color", oldColor);

	}

}
