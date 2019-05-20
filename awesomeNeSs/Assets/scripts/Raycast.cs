using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {

	// Use this for initialization
	public float selectionDistance = 1f;
	public LayerMask layerMask;
	private GameObject currentTarget;
	
	// Update is called once per frame
	void Update () {
		
		RaycastHit hit;
		if (Physics.Raycast (transform.position, transform.forward, out hit, selectionDistance, layerMask)) {
			if (currentTarget == null) {
				currentTarget = hit.transform.gameObject;
				OnRaycastEnter (currentTarget);
			} else if (currentTarget != hit.transform.gameObject) {
				OnRaycastLeave (currentTarget);
				currentTarget = hit.transform.gameObject;
				OnRaycastEnter (currentTarget);

			}
			OnRaycast (hit.transform.gameObject);

		} else if (currentTarget != null) {
			OnRaycastLeave (currentTarget);
			currentTarget = null;
		}
	}

		protected virtual void OnRaycastEnter(GameObject currentTarget)
		{
		
		}
		protected virtual void OnRaycastLeave(GameObject target)
		{
		}
		protected virtual void OnRaycast(GameObject target)
		{


		}
}
