using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPCamera : MonoBehaviour 
{
	public Transform target;
	private Transform Camera; 

	void Start () 
	{
		Camera = GetComponent <Transform> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Camera.localPosition = target.localPosition;
	}
}
