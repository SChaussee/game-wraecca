using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFloat : MonoBehaviour {

	public float posAmpX;         
	public float posSpeedX; 
	public float posAmpY;         
	public float posSpeedY; 
	public float posAmpZ;         
	public float posSpeedZ;
	public float rotAmpX;         
	public float rotSpeedX; 
	public float rotAmpY;         
	public float rotSpeedY; 
	public float rotAmpZ;         
	public float rotSpeedZ;
	private float tempPosX;
	private float tempPosY;
	private float tempPosZ;
	private float tempRotX;
	private float tempRotY;
	private float tempRotZ;
	private Vector3 tempPos;
	private Vector3 tempRot;

	void Start () 
	{
		tempPosX = transform.position.x;
		tempPosY = transform.position.y;
		tempPosZ = transform.position.z;
		tempRotX = transform.rotation.x;
		tempRotY = transform.rotation.y;
		tempRotZ = transform.rotation.z;
	}

	void Update () 
	{       
		tempPos.x = tempPosX + posAmpX * Mathf.Sin(posSpeedX * Time.time);
		tempPos.y = tempPosY + posAmpY * Mathf.Sin(posSpeedY * Time.time);
		tempPos.z = tempPosZ + posAmpZ * Mathf.Sin(posSpeedZ * Time.time);

		tempRot.x = tempRotX + rotAmpX * Mathf.Sin(rotSpeedX * Time.time);
		tempRot.y = tempRotY + rotAmpY * Mathf.Sin(rotSpeedY * Time.time);
		tempRot.z = tempRotZ + rotAmpZ * Mathf.Sin(rotSpeedZ * Time.time);

		transform.rotation = Quaternion.Euler(tempRot.x, tempRot.y, tempRot.z);
		transform.position = tempPos;

	}
}
