using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Asteroids : MonoBehaviour
{
    public GameObject asteroidPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnAsteroids");
    }

    IEnumerator SpawnAsteroids()
    {
        for (;;)
        {
            float randomX = Random.Range(8.7f, 11.7f);
            float randomY = Random.Range(-5.25f, 4.38f);
            Vector2 spawnPosition = new Vector2(randomX, randomY);
            Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(1f, 2.5f));
        }
    }
}
