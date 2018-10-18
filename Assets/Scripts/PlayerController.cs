﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Animator anim;
	public float inputDelay=0.1f;
	public float forwardVel=12;
	public float rotateVel=100;
	Quaternion targetRotation;
	Rigidbody rBody;
	float forwardInput, turnInput;
	public Quaternion TargetRotation
	{
		get { return targetRotation; }
	}	

	void Start ()
	{	
		targetRotation = transform.rotation;
		rBody = GetComponent<Rigidbody> ();
		forwardInput = turnInput = 0;
		anim= GetComponent<Animator> ();
	}
	void GetInput(){
		forwardInput = Input.GetAxis ("Vertical");
		turnInput = Input.GetAxis ("Horizontal");
	}
	void Update ()
	{
		GetInput ();
		Turn ();
	}
	void FixedUpdate ()
	{
		Run ();
	}
	void Run(){
		if (Mathf.Abs (forwardInput) > inputDelay) {
			//move
			rBody.velocity = transform.forward * forwardInput * forwardVel;
		} else
			rBody.velocity = Vector3.zero;
	}
	void Turn(){
		if (Mathf.Abs (turnInput) > inputDelay) {
			targetRotation *= Quaternion.AngleAxis (rotateVel * turnInput * Time.deltaTime, Vector3.up);
		}
		transform.rotation = TargetRotation;
	}
}
