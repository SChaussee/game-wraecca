using UnityEngine;
using System.Collections;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloud;
    public Vector3 spawnValues;
    public int cloudCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    void Start ()
    {
        StartCoroutine (SpawnWaves ());
    }

    IEnumerator SpawnWaves ()
    {
        yield return new WaitForSeconds (startWait);
        while (true)
        {
            for (int i = 0; i < cloudCount; i++)
            {
                Vector3 spawnPosition = new Vector3 (spawnValues.x, spawnValues.y, Random.Range (50, 650));
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate (cloud, spawnPosition, spawnRotation);
                yield return new WaitForSeconds (spawnWait);
            }
            yield return new WaitForSeconds (waveWait);
        }
    }
}