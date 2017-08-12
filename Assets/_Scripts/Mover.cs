using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
	public float speed;

	void Start ()
	{
	}

	void Update()
	{
		transform.Translate((Time.deltaTime) * speed, 0, 0);
	}
}
