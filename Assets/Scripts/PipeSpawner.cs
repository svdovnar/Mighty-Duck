using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float timeToSpawn = 2f;
    [SerializeField] private float minYposition;
    [SerializeField] private float maxYposition;
    private float timer;
    private void Start()
    {
        timer = timeToSpawn;
    }
    private void Update()
    {
        if (timer <= 0)
        {
            timer = timeToSpawn;
            GameObject pipe = Instantiate(pipePrefab, transform.position, Quaternion.identity);
            float randomSpawn = Random.Range(minYposition, maxYposition);
            pipe.transform.position = new Vector3(pipe.transform.position.x, randomSpawn, 0);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
