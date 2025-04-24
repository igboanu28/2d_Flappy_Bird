using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public Vector2 spawnRate = new Vector2(3,5);
    public float buffer = 10;
    private float lastSpawn = 0;
    public float heightOffset = 10;
    private float nextSpawn = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (lastSpawn+nextSpawn < Time.realtimeSinceStartup)
        {

            spawnPipe();
        }

    }
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        lastSpawn = Time.realtimeSinceStartup;
        nextSpawn = Random.Range(spawnRate.x, spawnRate.y);

    }
}