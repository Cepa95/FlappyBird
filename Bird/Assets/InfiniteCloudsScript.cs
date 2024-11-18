using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteCloudsScript : MonoBehaviour
{
    public GameObject cloud;
    public float spawnTime = 1.7f;
    private float elapsedTime = 0f;
    public float heightOffset = 3.5f;

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
            spawnClouds();
            elapsedTime = 0f;
        }
    }

    void spawnClouds()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z), transform.rotation);
    }
}