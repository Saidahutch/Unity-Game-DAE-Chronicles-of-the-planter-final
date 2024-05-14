using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sp : MonoBehaviour
{
    public GameObject platformPrefab;
    public Transform[] spawnPoints;
    public float spawnInterval = 2f;

    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnPlatform();
            timer = 0f;
        }
    }
    void SpawnPlatform()
    {
        int randomIndex = Random.Range (0, spawnPoints.Length);
        Instantiate (platformPrefab, spawnPoints[randomIndex].position, Quaternion.identity);
    }
}
