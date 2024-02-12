using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    public float spawnDistance = 15f;

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < spawnDistance)
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);  //spawns enemy at spawner's position
        
        this.enabled = false; //disables the script
    }
}
