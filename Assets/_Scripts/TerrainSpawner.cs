using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSpawner : MonoBehaviour {
	
	public GameObject terrain;                // The enemy prefab to be spawned.
	public float spawnTime = 3f;            // How long between each spawn.
	public Transform spawnPoints;         // An array of the spawn points this enemy can spawn from.

	void Start ()
	{
		Instantiate (terrain, spawnPoints.position, spawnPoints.rotation);
		// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}


	void Spawn ()
	{
		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		Debug.Log("Terrain spawned!");
		Instantiate (terrain, spawnPoints.position, spawnPoints.rotation);
	}
}
