using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinitePylonScript : MonoBehaviour
{
    public GameObject pylon;
    public float spawnTime = 1f;
    public float heightOffset = 2.2f;

    private float elapsedTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= spawnTime)
        {
            elapsedTime = 0f;
            SpawnPylon();
        }
    }

    void SpawnPylon()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Vector3 spawnPosition = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z);
        Instantiate(pylon, spawnPosition, transform.rotation);
    }
}
