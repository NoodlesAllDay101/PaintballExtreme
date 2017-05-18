using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1 : MonoBehaviour 
{

	public float Speed;
	private Rigidbody rb;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent <Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{

		float Vertical = Input.GetAxis ("P1 Vertical");
		float Horizontal = Input.GetAxis ("P1 Horizontal");
		float Jump = Input.GetAxis ("P1 Jump");
		bool Shoot = Input.GetAxis ("P1 Shoot") > 0;

		if (Vertical > 0) 
		{
			Vertical = Speed;
		} 
		else if (Vertical < 0) 
		{
			Vertical = -Speed; 
		} 
		else 
		{
			Vertical = 0;
		}

		if (Horizontal > 0) 
		{
			Horizontal = Speed;
		} 
		else if (Horizontal < 0) 
		{
			Horizontal = -Speed; 
		} 
		else 
		{
			Horizontal = 0;
		}

		if (Jump > 0)
		{
			Jump = Speed;
		} 
		else if (Jump < 0)
		{
			Jump = -Speed; 
		}
		else
		{
			Jump = 0;
		}

		Vector3 pos = rb.position;

		rb.MovePosition	(pos + new Vector3 (Horizontal, Jump, Vertical));

	}
}
