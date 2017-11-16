using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class WarperScript : MonoBehaviour
{

	public Vortex vortex;

	void Start ()
	{
		
	}

	void Update ()
	{
		Vector3 screenSpacePoint = Camera.main.WorldToViewportPoint (this.transform.position);
		vortex.center = new Vector2 (screenSpacePoint.x, screenSpacePoint.y);
	}
}
