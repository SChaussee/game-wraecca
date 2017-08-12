using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {

	void OnTriggerExit(Collider other)
	{
		Debug.Log("Terrain destroyed!");
		Destroy(other.gameObject);
	}
}
